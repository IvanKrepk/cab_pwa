// sheet_menu_account.dart
import 'package:flutter/material.dart';
class MenuAccount extends StatelessWidget {

  // Функция для закрытия меню
  final VoidCallback onClose;

  // Функция для перехода на страницу Аккаунт
  final VoidCallback onShowAccountPage;

  final VoidCallback onLogout;

  // Конструктор
  const MenuAccount({
    super.key,
    required this.onShowAccountPage,
    required this.onLogout,
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
              // Скрываем меню после выбора данного пункта
              onClose();
              
              // Переход на страницу Аккаунт
              onShowAccountPage();
            },
          ),
          ListTile(
            leading: Icon(Icons.logout, color: colorScheme.primary),
            title: Text("Выход"),
            onTap: () {
              // Скрываем меню после выбора данного пункта
              onClose();
              
              // Выполняем выход из аккаунта
              onLogout();
            },
          ),
        ],
      ),
    );
  }
}