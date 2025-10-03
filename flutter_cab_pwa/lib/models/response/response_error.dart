// models/response/response_error.dart
import 'response.dart';

class ResponseError extends Response {
  final String? message;

  ResponseError({this.message}); 

  factory ResponseError.fromJson(Map<String, dynamic> json) {
    return ResponseError(
      message: json["message"]
    );
  } 
}