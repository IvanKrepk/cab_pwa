// models/request/request_cab_account_update.dart
import "request_cab.dart";

class RequestCabAccountUpdate extends RequestCab {
  final int accountNumber;
  final String webLogin;
  final String accountNameNew;
  final String passwordNew;

  RequestCabAccountUpdate(
    this.accountNumber, 
    this.webLogin,
    this.accountNameNew,
    this.passwordNew
  );

  @override
  Map<String, dynamic> toJson() {
    return {
      "account_number": accountNumber,
      "web_login": webLogin,
      "account_name_new": accountNameNew,
      "password_new": passwordNew
    };
  }  
}