// services/service_api.dart
import 'dart:convert';
import 'package:flutter_cab_pwa/models/request/request_cab.dart';
import 'service_client_manager.dart';
import 'package:http/http.dart' as http;
import '../models/request/request_cab_login.dart';
import '../models/request/request_cab_account_update.dart';
import '../models/response/response_cab_account_update.dart';
import 'package:flutter_cab_pwa/models/response/response_cab_error.dart';
import 'package:flutter_cab_pwa/models/response/response_cab_login.dart';
import 'package:flutter_cab_pwa/models/response/response_cab.dart';

class ServiceApi {
  
  // Метод makeResponse
  static Future<http.Response> _makePostRequest(
    String method, 
    RequestCab request,
  ) async {
    
    // Уникальный id приложения
    final String clientId = await ServiceClientManager.getAppId(); 

    // Url Api
    final String apiUrl = await ServiceClientManager.getApiUrl();

    // token
    final String token = await ServiceClientManager.getToken(); 

    var url = Uri.https(apiUrl, method);
    http.Response response = await http.post(
      url,
      headers: <String, String> {
        'Content-Type': 'application/json; charset=UTF-8',
        'X-Client-ID': clientId,
        'Authorization': 'Bearer $token'
      },
      body: jsonEncode(request.toJson())
    );

    return response;
  } 

  // Метод login
  static Future<ResponseCab> login(RequestCabLogin request) async {
    var response = await _makePostRequest('CabPwa/login', request);
    int status = response.statusCode;
    if (status != 200) {
      try {
        return ResponseCabError.fromJson(status, jsonDecode(response.body));
      } catch (e) {
        return ResponseCabError(status, message: "Ошибка выполнения запроса");
      }
    } else {
      return ResponseCabLogin.fromJson(status, jsonDecode(response.body));
    }
  }

  // Метод account_update
  static Future<ResponseCab> accountUpdate(RequestCabAccountUpdate request) async {
    var response = await _makePostRequest('CabPwa/account/update', request);

    int status = response.statusCode;
    if (status != 200) {
      try {
        return ResponseCabError.fromJson(status, jsonDecode(response.body));
      } catch (e) {
        return ResponseCabError(status, message: "Ошибка выполнения запроса");
      }
    } else {
      return ResponseCabAccountUpdate.fromJson(status, jsonDecode(response.body));
    }
  }
}