// models/response/response_login.dart
import 'response.dart';

class ResponseLogin extends Response {
  final String? userName;
  final String? displayName;
  final int? cardCode;
  final int? cardNumber;
  final String? cardFullNumber;
  final int? emitentCode;
  final int? accountNumber;
  final String? token;

  ResponseLogin(
    this.userName,
    this.displayName,
    this.cardCode,
    this.cardNumber,
    this.cardFullNumber,
    this.emitentCode,
    this.accountNumber,
    this.token
  );

  factory ResponseLogin.fromJson(Map<String, dynamic> json) {
    return ResponseLogin(
      json["user_name"], 
      json["display_name"], 
      json["card_code"], 
      json["card_number"], 
      json["card_full_number"], 
      json["emitent_code"], 
      json["account_number"], 
      json["token"]
    );
  }
}