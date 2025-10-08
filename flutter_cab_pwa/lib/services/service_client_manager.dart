// services/service_client_manager.dart
import 'package:shared_preferences/shared_preferences.dart';
import 'package:uuid/uuid.dart';

// Класс для генерации уникального идентификатора экземпляра приложения
class ServiceClientManager {

  static final String _keyAppId = "app_id";
  static final String _keyApiUrl = "api_url";
  static final String _keyToken = "token";

  // Метод получения Id приложения
  static Future<String> getAppId() async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();

    String? clientId = prefs.getString(_keyAppId);

    if (clientId == null) {
      clientId = const Uuid().v4();                   // генерируем новый UUID
      await prefs.setString(_keyAppId, clientId);
    }

    return clientId;
  }

  // Метод получения Url API
  static Future<String> getApiUrl() async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();

    String? apiUrl = prefs.getString(_keyApiUrl);
    if (apiUrl == null) {
      apiUrl = "localhost:7247";                // Доделать потом
      prefs.setString(_keyApiUrl, apiUrl);
    }
    return apiUrl;
  }

  // Установить токен
  static void setToken(String token) async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();
    prefs.setString(_keyToken, token);
  }

  // Получить токен
  static Future<String> getToken() async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();

    String? token = prefs.getString(_keyToken);

    return token ?? "";
  }
}