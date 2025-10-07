// services/service_client_manager.dart
import 'package:shared_preferences/shared_preferences.dart';
import 'package:uuid/uuid.dart';

// Класс для генерации уникального идентификатора экземпляра приложения
class ServiceClientIdManager {

  static final String _keyAppId = "app_id";

  // Метод получения Id приложения
  static Future<String> get() async {
    final SharedPreferences prefs = await SharedPreferences.getInstance();

    String? clientId = prefs.getString(_keyAppId);

    if (clientId == null) {
      clientId = const Uuid().v4();                   // генерируем новый UUID
      await prefs.setString(_keyAppId, clientId);
    }

    return clientId;
  }
}