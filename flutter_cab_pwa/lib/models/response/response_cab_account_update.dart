// models/response/response_cab_account_update.dart
import 'response_cab.dart';

class ResponseCabAccountUpdate extends ResponseCab {
  final String message;

  ResponseCabAccountUpdate(this.message);

  factory ResponseCabAccountUpdate.fromJson(Map<String, dynamic> json) {
    return ResponseCabAccountUpdate(json["message"]);
  }
}