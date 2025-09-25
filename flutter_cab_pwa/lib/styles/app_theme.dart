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

  // Стиль для полей ввода текста
  inputDecorationTheme: InputDecorationTheme(
    labelStyle: WidgetStateTextStyle.resolveWith((Set<WidgetState> states) {
      if (states.contains(WidgetState.error)) {
        return TextStyle(color: appColorSheme.error);
      }
      return TextStyle(color: appColorSheme.onSurface.withAlpha(170));
    }),
    
    border: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.outline),
      borderRadius: appElementBorderRadius,
    ),
    enabledBorder: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.outline),
      borderRadius: appElementBorderRadius,
    ),
    focusedBorder: OutlineInputBorder(
      borderRadius: appElementBorderRadius,
      borderSide: BorderSide(width: 2, color: appColorSheme.primary),
    ),
    errorBorder: OutlineInputBorder(
      borderSide: BorderSide(color: appColorSheme.error),
      borderRadius: appElementBorderRadius,
    ),
    
    contentPadding: EdgeInsets.symmetric(horizontal: 16, vertical: 12),
  ),

  // Стиль для кнопок
  elevatedButtonTheme: ElevatedButtonThemeData(
    style: ElevatedButton.styleFrom(
      shape: RoundedRectangleBorder(
        borderRadius: appElementBorderRadius
      ),
      backgroundColor: appColorSheme.primary,
      foregroundColor: appColorSheme.onPrimary,
      textStyle: TextStyle(
        height: 1
      )
    )
  ),

  // Стили для шрифтов
  textTheme: TextTheme(
    headlineSmall: TextStyle(
      fontFamily: "Roboto",
      fontWeight: FontWeight.w900
    ),
    titleMedium: TextStyle(
      fontFamily: 'Roboto',
      fontWeight: FontWeight.bold
    )
  )

);