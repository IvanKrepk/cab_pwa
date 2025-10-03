// screen_login.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/models/request_login.dart';
import 'styles/styles_shapes.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'services/service_api.dart';
import 'services/service_ui.dart';
import 'models/response/response.dart';
import 'models/response/response_error.dart';
import 'models/response/response_login.dart';
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
                          Response response = await ServiceApi.login(
                            RequestLogin(
                              _loginController.text,
                              _passwordController.text
                            )
                          );
                          if (response is ResponseLogin) {
                            // Логинимся...
                            ResponseLogin loginResponse = response;
                            
                            // Переход на главный экран
                            if (context.mounted) {
                              Navigator.pushReplacement(
                                context,
                                MaterialPageRoute(builder: (context) => ScreenMain()),
                              );
                            }
                          } else if (response is ResponseError) {
                            // Выводим сообщение об ошибке
                            ResponseError errorResponse = response;
                            if (context.mounted) {
                              ServiseUI.showErrorMessage(
                                context,
                                errorResponse.message
                              );
                            }
                          }
                        },
                      ),
                      ElevatedButton(
                        onPressed: (){}, 
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