// page_account.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';

class PageAccount extends StatelessWidget {
  const PageAccount({super.key});

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    return Container(
      margin: appContainerMargin,
      decoration: BoxDecoration(
        color: colorScheme.surface
      ),
      child: Column (
        children: [
          Text(
            "Аккаунт",
            style: themeData.textTheme.displayMedium?.apply(
              color: colorScheme.onSurface
            ),
          ),
          Text(
            "Основная информация",
            style: themeData.textTheme.displayMedium?.apply(
              color: colorScheme.onSurface
            ),
          )
        ]
      )
    );
  }
}