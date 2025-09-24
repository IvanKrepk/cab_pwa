// main.dart
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'styles/app_theme.dart';
import 'styles/styles_shapes.dart';

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

class LoginScreen extends StatelessWidget {
  const LoginScreen({super.key});

  @override
  Widget build(BuildContext context) {
    final ThemeData theme = Theme.of(context);
    final ColorScheme colorScheme = theme.colorScheme;

    return Scaffold(
      backgroundColor: Colors.blue,
      body: Center(
        child: ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 400),
          child: Container(
            padding: appBoxPadding,
            decoration: BoxDecoration(
              borderRadius: appBoxBorderRadius,
              color: colorScheme.surfaceContainerLowest
            ),
            child: SizedBox(
              width: MediaQuery.of(context).size.width * 0.7,
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  Row(
                    children: [
                      SvgPicture.asset("assets/elsy_icon.svg", width: 40, height: 40),
                      Text("Кабинет водителя",style: theme.textTheme.headlineSmall),
                    ]
                  ),
                  Align(
                    alignment: Alignment.center,
                    child: Text("Пожалуйста, представьтесь")
                  ),
                  TextField(
                    decoration: InputDecoration(
                      labelText: "Логин",
                    ),
                  ),
                  TextField(
                    obscureText: true,
                    decoration: InputDecoration(
                      labelText: "Пароль",
                    ),
                  ),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: [
                      ElevatedButton(
                        onPressed: (){}, 
                        child: Text("Войти")
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
