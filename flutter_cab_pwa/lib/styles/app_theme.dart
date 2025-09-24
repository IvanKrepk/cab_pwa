// styles/app_theme.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';

// Цветовая схема
ColorScheme appColorSheme = ColorScheme.fromSeed(
  seedColor: Colors.blue,
  brightness: Brightness.light 
);

final appTheme = ThemeData(
  useMaterial3: true,
  colorScheme: appColorSheme,
  inputDecorationTheme: InputDecorationTheme(
    labelStyle: WidgetStateTextStyle.resolveWith((Set<WidgetState> states) {
      if (states.contains(WidgetState.error)) {
        return TextStyle(color: appColorSheme.error);
      }
      return TextStyle(color: appColorSheme.onSurface.withAlpha(170));
    }),
    
    border: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.outline),
      borderRadius: appTexBoxBorderRadius,
    ),
    enabledBorder: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.outline),
      borderRadius: appTexBoxBorderRadius,
    ),
    focusedBorder: OutlineInputBorder(
      borderRadius: appTexBoxBorderRadius,
      borderSide: BorderSide(width: 2, color: appColorSheme.primary),
    ),
    errorBorder: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.error),
      borderRadius: appTexBoxBorderRadius,
    ),
    
    contentPadding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
  ),

);