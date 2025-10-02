// api_service.dart
import 'dart:convert';

import '../models/login_request.dart';
import 'package:http/http.dart' as http;

class ApiService {
  static void login() async {

    LoginRequest request = LoginRequest('333', '333');

    var url = Uri.https('localhost:7247', 'CabPwa/login');
    var response = await http.post(
      url, 
      headers: <String, String> {
        'Content-Type': 'application/json; charset=UTF-8',
      },
      body: jsonEncode(request.toJson())
    );
    int status = response.statusCode;
  }
}