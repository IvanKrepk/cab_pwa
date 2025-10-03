// services/service_api.dart
import 'dart:convert';
import 'package:flutter_cab_pwa/models/response/response_error.dart';
import 'package:flutter_cab_pwa/models/response/response_login.dart';
import 'package:flutter_cab_pwa/models/response/response.dart';
import '../models/request_login.dart';
import 'package:http/http.dart' as http;

class ServiceApi {
  // Метод login
  static Future<Response> login(RequestLogin requestLogin) async {

    RequestLogin request = RequestLogin(
      requestLogin.webLogin, 
      requestLogin.password
    );

    var url = Uri.https('localhost:7247', 'CabPwa/login');
    var response = await http.post(
      url, 
      headers: <String, String> {
        'Content-Type': 'application/json; charset=UTF-8',
      },
      body: jsonEncode(request.toJson())
    );
    int status = response.statusCode;
    if (status != 200) {
      return ResponseError.fromJson(jsonDecode(response.body));
    } else {
      return ResponseLogin.fromJson(jsonDecode(response.body));
    }
  }
}