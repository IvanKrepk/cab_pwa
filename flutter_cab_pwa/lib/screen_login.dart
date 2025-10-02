// screen_login.dart
import 'package:flutter/material.dart';
import 'styles/styles_shapes.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'services/api_service.dart';

class ScreenLogin extends StatelessWidget {
  const ScreenLogin({super.key});

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
                    decoration: InputDecoration(
                      labelText: "Логин",
                    ),
                  ),
                  SizedBox(height: 10),
                  TextField(
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
                        onPressed: () {
                          // Попытка залогиниться                        
                          ApiService.login();
                          // Переход на главный экран
                          //Navigator.pushReplacement(
                          //  context,
                          //  MaterialPageRoute(builder: (context) => ScreenMain()),
                          //);
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