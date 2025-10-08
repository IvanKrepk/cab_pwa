// models/request/request_cab_account_update.dart
import "request_cab.dart";

class RequestCabAccountUpdate extends RequestCab {
  final int accountNumber;
  final String accountNameNew;
  final String passwordNew;

  RequestCabAccountUpdate(
    this.accountNumber, 
    this.accountNameNew,
    this.passwordNew
  );

  @override
  Map<String, dynamic> toJson() {
    return {
      "account_number": accountNumber,
      "account_name_new": accountNameNew,
      "password_new": passwordNew
    };
  }  
}