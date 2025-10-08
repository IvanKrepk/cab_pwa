// models/request/request_cab_login.dart
import 'request_cab.dart';

class RequestCabLogin extends RequestCab {
  final String webLogin;
  final String password;

  RequestCabLogin(this.webLogin, this.password);

  @override
  Map<String, dynamic> toJson() {
    return {
      "web_login": webLogin,
      "password": password
    };
  }
}