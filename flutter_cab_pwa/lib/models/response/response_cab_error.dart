// models/response/response_cab_error.dart
import 'response_cab.dart';

class ResponseCabError extends ResponseCab {
  final String? message;

  ResponseCabError({this.message}); 

  factory ResponseCabError.fromJson(Map<String, dynamic> json) {
    return ResponseCabError(
      message: json["message"]
    );
  } 
}