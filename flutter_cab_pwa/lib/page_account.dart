// page_account.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/services/service_user_session.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';
import 'element_password_field.dart';

class PageAccount extends StatefulWidget {
  const PageAccount({super.key});
  
  @override
  State<StatefulWidget> createState() => _PageAccountState();
}
class _PageAccountState extends State<PageAccount> {

  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _displayNameController = TextEditingController();

  @override
  void dispose() {
    
    _passwordController.dispose();
    _displayNameController.dispose();

    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    // Заполняем Отображаемое имя
    _displayNameController.text = UserSession().displayName ?? "";

    return Container(
      margin: appContainerMargin,
      decoration: BoxDecoration(
        color: colorScheme.surface
      ),
      child: Align(
        alignment: Alignment.topCenter,
        child: Column (
          mainAxisSize: MainAxisSize.min,
          children: [
            Text(
              "Аккаунт",
              style: themeData.textTheme.displayMedium?.apply(
                color: colorScheme.onSurface
              ),
            ),
            SizedBox(height: 15),
            Text(
              "Основная информация",
              style: themeData.textTheme.headlineMedium?.apply(
                color: colorScheme.onSurface
              ),
            ),
            // Имя пользователя
            Center(
                child: Container(
                  margin: EdgeInsets.only(top: 20),
                  padding: appContainerPadding,
                  decoration: BoxDecoration(
                    borderRadius: appContainerBorderRadius,
                    color: colorScheme.surfaceContainerLowest
                  ),
                  child: Column(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      Align(
                        alignment: Alignment.centerLeft,
                        child: Text(
                          "Имя пользователя",
                          style: themeData.textTheme.titleLarge?.apply(
                            color: colorScheme.onSurface
                          ),
                        )
                      ),
                      SizedBox(height: 10),
                      Align(
                        alignment: Alignment.centerLeft,
                        child: Text(
                          UserSession().userName ?? "Не определён",
                          style: themeData.textTheme.titleLarge?.apply(
                            color: colorScheme.onSurface
                          ),
                        )
                      )
                    ],
                  ),
                )
              ),
            // Новый пароль
            Center(
              child: Container(
                margin: EdgeInsets.only(top: 10),
                padding: appContainerPadding,
                decoration: BoxDecoration(
                  borderRadius: appContainerBorderRadius,
                  color: colorScheme.surfaceContainerLowest
                ),
                child: Column(
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        "Новый пароль",
                        style: themeData.textTheme.titleLarge?.apply(
                          color: colorScheme.onSurface
                        ),
                      )
                    ),
                    SizedBox(height: 10),
                    Align(
                      alignment: Alignment.centerLeft,
                      child: ConstrainedBox(
                        constraints: BoxConstraints(maxWidth: 300),
                        child: ElementPasswordField()
                      )                       
                    )
                  ],
                ),
              )
            ),
            // Отображаемое имя
            Center(
              child: Container(
                margin: EdgeInsets.only(top: 10),
                padding: appContainerPadding,
                decoration: BoxDecoration(
                  borderRadius: appContainerBorderRadius,
                  color: colorScheme.surfaceContainerLowest
                ),
                child: Column(
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        "Отображаемое имя",
                        style: themeData.textTheme.titleLarge?.apply(
                          color: colorScheme.onSurface
                        ),
                      )
                    ),
                    SizedBox(height: 10),
                    Align(
                      alignment: Alignment.centerLeft,
                      child: ConstrainedBox(
                        constraints: BoxConstraints(maxWidth: 300), 
                        child: TextField(
                          controller: _displayNameController,
                        ),
                      )                    
                    )
                  ],
                ),
              )
            ),
            SizedBox(height: 10),
            SizedBox(
              width: double.infinity,
              child: ElevatedButton( 
                style: ElevatedButton.styleFrom(
                  padding: EdgeInsets.symmetric(vertical: 20)
                ),
                child: Text(
                  "Сохранить", 
                  style: themeData.textTheme.titleMedium?.apply(
                    color: colorScheme.onPrimary
                  )
                ),
                onPressed: (){
                  // Сохраняем настройки аккаунта ...
                }
              )
            )
          ]
        )
      )
    );
  }
}