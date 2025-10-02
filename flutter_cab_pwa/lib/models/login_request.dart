// models/login_request.dart

class LoginRequest {
  final String? webLogin;
  final String? password;

  LoginRequest(this.webLogin, this.password);

  Map<String, dynamic> toJson() {
    return {
      "web_login": webLogin,
      "password": password
    };
  }
}