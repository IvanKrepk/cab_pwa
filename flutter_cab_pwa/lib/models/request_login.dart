// models/request_login.dart

class RequestLogin {
  final String? webLogin;
  final String? password;

  RequestLogin(this.webLogin, this.password);

  Map<String, dynamic> toJson() {
    return {
      "web_login": webLogin,
      "password": password
    };
  }
}