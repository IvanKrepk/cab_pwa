// models/response/response_cab_login.dart
import 'response_cab.dart';

class ResponseCabLogin extends ResponseCab {
  final String? webLogin;
  final String? accountName;
  final int? cardCode;
  final int? cardNumber;
  final String? cardFullNumber;
  final int? emitentCode;
  final int? accountNumber;
  final String token;

  ResponseCabLogin(
    super.status,
    this.webLogin,
    this.accountName,
    this.cardCode,
    this.cardNumber,
    this.cardFullNumber,
    this.emitentCode,
    this.accountNumber,
    this.token
  );

  factory ResponseCabLogin.fromJson(int status, Map<String, dynamic> json) {
    return ResponseCabLogin(
      status,
      json["web_login"], 
      json["account_name"], 
      json["card_code"], 
      json["card_number"], 
      json["card_full_number"], 
      json["emitent_code"], 
      json["account_number"], 
      json["token"]
    );
  }
}