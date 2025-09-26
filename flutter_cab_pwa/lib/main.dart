// main.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/screen_login.dart';
import 'styles/app_theme.dart';

void main() {
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
