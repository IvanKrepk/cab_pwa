// screen_login.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/models/request/request_cab_login.dart';
import 'package:flutter_cab_pwa/services/service_user_session.dart';
import 'package:flutter_cab_pwa/services/service_client_manager.dart';
import 'styles/styles_shapes.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'services/service_api.dart';
import 'services/service_ui.dart';
import 'models/response/response_cab.dart';
import 'models/response/response_cab_error.dart';
import 'models/response/response_cab_login.dart';
import 'screen_main.dart';

class ScreenLogin extends StatefulWidget {
  const ScreenLogin({super.key});

  @override
  State<StatefulWidget> createState() => _ScreenLoginState();
}

class _ScreenLoginState extends State<ScreenLogin> {

  final TextEditingController _loginController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();

  @override
  void dispose() {
    _loginController.dispose();
    _passwordController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    return Scaffold(
      backgroundColor: Colors.blue,
      body: Center(
        child: ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 400),
          child: Container(
            padding: appContainerPadding,
            decoration: BoxDecoration(
              borderRadius: appContainerBorderRadius,
              color: colorScheme.surfaceContainerLowest
            ),
            child: SizedBox(
              width: MediaQuery.widthOf(context) * 0.7,
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  Row(
                    children: [
                      SvgPicture.asset(
                        "assets/elsy_icon.svg", width: 40, height: 40, 
                      ),
                      SizedBox(width: 5),
                      Text("Кабинет водителя",
                        style: themeData.textTheme.headlineMedium
                      ),
                    ]
                  ),
                  SizedBox(height: 35),
                  Align(
                    alignment: Alignment.center,
                    child: Text(
                      "Пожалуйста, представьтесь",
                      style: themeData.textTheme.titleMedium,
                    )
                  ),
                  SizedBox(height: 10),
                  TextField(
                    controller: _loginController,
                    decoration: InputDecoration(
                      labelText: "Логин",
                    ),
                  ),
                  SizedBox(height: 10),
                  TextField(
                    controller: _passwordController,
                    obscureText: true,
                    decoration: InputDecoration(
                      labelText: "Пароль",
                    ),
                  ),
                  SizedBox(height: 15),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: [
                      ElevatedButton( 
                        child: Text("Войти"),
                        onPressed: () async {
                          // Попытка залогиниться                        
                          ResponseCab response = await ServiceApi.login(
                            RequestCabLogin(
                              _loginController.text,
                              _passwordController.text
                            )
                          );
                          if (response is ResponseCabLogin) {
                            // Сохраняем сессию
                            ResponseCabLogin loginResponse = response;
                            UserSession().saveUserData(loginResponse);
                            
                            // Сохраняем токен
                            ServiceClientManager.setToken(loginResponse.token);

                            // Переход на главный экран
                            if (context.mounted) {
                              Navigator.pushReplacement(
                                context,
                                MaterialPageRoute(builder: (context) => ScreenMain()),
                              );
                            }
                          } else if (response is ResponseCabError) {
                            // Выводим сообщение об ошибке
                            ResponseCabError errorResponse = response;
                            if (context.mounted) {
                              ServiceUI.showErrorMessage(
                                context,
                                errorResponse.message
                              );
                            }
                          }
                        },
                      ),
                      ElevatedButton(
                        onPressed: (){
                          // Логика "Забыли пароль?"
                        }, 
                        child: Text("Забыли пароль?")
                      )
                    ],
                  )
                ]
              )
            )
          )
        )
      )
    );
  }
}