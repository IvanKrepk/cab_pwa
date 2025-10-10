// models/response/response_cab_error.dart
import 'response_cab.dart';

class ResponseCabError extends ResponseCab {
  final String? message;

  ResponseCabError(super.status, {this.message}); 

  factory ResponseCabError.fromJson(int status, Map<String, dynamic> json) {
    return ResponseCabError(
      status = status,
      message: json["message"]
    );
  } 
}