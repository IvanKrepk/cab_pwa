// main.dart
import 'package:flutter/material.dart';
import 'styles/app_theme.dart';
import 'login_screen.dart';

void main() {
  runApp(MainApp());
}

class MainApp extends StatelessWidget {
  const MainApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: appTheme,
      home: LoginScreen()
    );
  }
}
