// models/response/response_cab_account_update.dart
import 'response_cab.dart';

class ResponseCabAccountUpdate extends ResponseCab {
  final String message;
  final String? accountNameNew;

  ResponseCabAccountUpdate(super.status, this.message, {this.accountNameNew});

  factory ResponseCabAccountUpdate.fromJson(int status, Map<String, dynamic> json) {
    return ResponseCabAccountUpdate(
      status = status,
      json["message"],
      accountNameNew: json["account_name_new"]
    );
  }
}