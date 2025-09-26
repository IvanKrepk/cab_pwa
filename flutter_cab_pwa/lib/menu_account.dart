// sheet_menu_account.dart
import 'package:flutter/material.dart';

class MenuAccount extends StatelessWidget {

  final VoidCallback onClose;

  const MenuAccount({
    super.key,
    required this.onClose
  });

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    return Material(
      elevation: 3,
      child: Column(
        mainAxisSize: MainAxisSize.min,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          ListTile(
            leading: Icon(Icons.person, color: colorScheme.primary),
            title: Text("Аккаунт"),
            onTap: () {
              onClose();
              // Перейти на страницу аккаунта
            },
          ),
          ListTile(
            leading: Icon(Icons.logout, color: colorScheme.primary),
            title: Text("Выход"),
            onTap: () {
              onClose();
              // Логика выхода
            },
          ),
        ],
      ),
    );
  }
}