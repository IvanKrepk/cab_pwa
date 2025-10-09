// models/response/response_cab_account_update.dart
import 'response_cab.dart';

class ResponseCabAccountUpdate extends ResponseCab {
  final String message;
  final String? accountNameNew;

  ResponseCabAccountUpdate(this.message, {this.accountNameNew});

  factory ResponseCabAccountUpdate.fromJson(Map<String, dynamic> json) {
    return ResponseCabAccountUpdate(
      json["message"],
      accountNameNew: json["account_name_new"]
    );
  }
}