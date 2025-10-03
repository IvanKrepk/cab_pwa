// main.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/screen_login.dart';
import 'styles/app_theme.dart';
import 'services/service_user_session.dart';

void main() async {
  // Важная строка, если нужно использовать асинхронные вызовы
  // до создания виджетов
  WidgetsFlutterBinding.ensureInitialized();

  // Инициализируем сессию
  await UserSession().init();

  // Запускаем главный виджет
  runApp(MainApp());
}

class MainApp extends StatelessWidget {
  const MainApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: appTheme,
      home: ScreenLogin()
    );
  }
}
