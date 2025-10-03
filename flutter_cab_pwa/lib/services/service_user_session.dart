// services/service_user_session.dart
import 'package:shared_preferences/shared_preferences.dart';
import '../models/response/response_login.dart';

class UserSession {
  // Singleton гарантирует, что в приложении будет только один экземпляр класса UserSession
  // _instance — статическая переменная, которая создаётся один раз.
  // factory UserSession() — фабричный конструктор, который всегда возвращает этот единственный экземпляр.
  // _internal() — приватный конструктор, чтобы никто не мог создать новый экземпляр снаружи.
  static final UserSession _instance = UserSession._internal();
  factory UserSession() => _instance;
  UserSession._internal();

  // Хранилище данных
  late SharedPreferences _prefs;

  // init() — асинхронный метод, который нужно вызвать один раз при запуске приложения.
  Future<void> init() async {
    _prefs = await SharedPreferences.getInstance();
  }

  // Сохраняем данные пользователя
  void saveUserData(ResponseLogin userData) {
    _prefs.setString('userName', userData.userName ?? '');
    _prefs.setString('displayName', userData.displayName ?? '');
    _prefs.setInt('cardCode', userData.cardCode ?? 0);
    _prefs.setInt('cardNumber', userData.cardNumber ?? 0);
    _prefs.setString('cardFullNumber', userData.cardFullNumber ?? '');
    _prefs.setInt('emitentCode', userData.emitentCode ?? 0);
    _prefs.setInt('accountNumber', userData.accountNumber ?? 0);
    _prefs.setString('token', userData.token ?? '');
  }

  // Получаем имя пользователя
  String? get userName => _prefs.getString('userName');

  // Получаем токен (всегда нужен для API)
  String? get token => _prefs.getString('token');

  // Проверяем, авторизован ли пользователь
  bool get isLoggedIn => _prefs.getString('token')?.isNotEmpty == true;

  // Очистка данных при выходе
  void clear() {
    _prefs.clear();
  }
}
