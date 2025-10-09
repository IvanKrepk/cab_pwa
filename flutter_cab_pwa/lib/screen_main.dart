// screen_main.dart
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'page_home.dart';
import 'page_account.dart';
import 'menu_account.dart';
import 'screen_login.dart';
import 'services/service_ui.dart';
import 'services/service_user_session.dart';

class ScreenMain extends StatefulWidget {
  const ScreenMain({super.key});

  @override
  State<StatefulWidget> createState() {
    return _StateMainScreen();
  }
}

// Перечисление страниц, которые могут быть отображены на главном экране
enum PagesMainScreen {
  pageHome,         // index = 0 -> PageHome()
  pageAccount       // index = 1 -> PageAccount()    
}  
class _StateMainScreen extends State<ScreenMain> {
  
  // Текуший индекс страницы на главном экране
  PagesMainScreen _currentPage = PagesMainScreen.pageHome;

  // Список страниц, для отображения на экране
  final List<Widget> _pages = [
    PageHome(),
    PageAccount()
  ];

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    return Scaffold(
      appBar: AppBar(
        backgroundColor: colorScheme.primary,
        title: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            // Логотип и название
            Row(
              children: [
                SvgPicture.asset(
                  "assets/elsy_icon.svg", 
                  width: 40, 
                  height: 40,
                  colorFilter: ColorFilter.mode(
                    colorScheme.onPrimary, 
                    BlendMode.srcIn
                  ),
                ),
                SizedBox(width: 5),
                TextButton(
                  child: Text("Кабинет водителя", 
                    style: themeData.textTheme.headlineSmall?.apply(
                      color: colorScheme.onPrimary
                    )
                  ),
                  onPressed: () {
                    setState(() {
                      _currentPage = PagesMainScreen.pageHome;
                    });
                  } ,
                )
              ],
            ),
            // Меню аккаунта и основное меню
            Row(
              children: [
                // Меню аккаунта
                IconButton(
                  icon: SvgPicture.asset(
                    "assets/user_icon.svg",
                    width: 40,
                    height: 40,
                    colorFilter: ColorFilter.mode(
                      colorScheme.onPrimary, 
                      BlendMode.srcIn
                    ),
                  ),
                  onPressed: (){
                    // Отображаем меню аккаунта
                    _showAccountMenu(context);
                  }
                ),
                // Основное меню
                IconButton(
                  icon: SvgPicture.asset(
                    "assets/menu_icon.svg",
                    width: 40,
                    height: 40,
                    colorFilter: ColorFilter.mode(
                      colorScheme.onPrimary, 
                      BlendMode.srcIn
                    ),
                  ),
                  onPressed: (){
                    // Пока не готово
                  }
                )
              ],
            )
          ],
        ),
      ),
      body: 
        IndexedStack(
          index: _currentPage.index,  // Индекс отображаемой страницы
          children: _pages            // Список страниц главного экрана
        ),
    );
  }

  // Процедура отображения и настройки меню Аккаунт
  void _showAccountMenu(BuildContext context) {
    double heightAppBar = kToolbarHeight;                               // Высота стандартного toolbar = 56.0
    double heightSystemStatusBar = MediaQuery.of(context).padding.top;  //высота системного toolbar на устройстве

    OverlayEntry? overlayEntry;

    overlayEntry = ServiceUI.showOverlayWidget(
      context,
      Positioned(
        top: heightAppBar + heightSystemStatusBar,                    // Вычисляем координату верхней границы меню, что бы меню открывалось ровно после toolbar приложения
        right: 0, 
        child: IntrinsicWidth(
          child: MenuAccount(
                  // Логика перехода на страницу Аккаунт
                  onShowAccountPage: () {
                    setState(() {
                      _currentPage = PagesMainScreen.pageAccount;
                    });
                  },
                  onLogout: () {
                    // Очищаем сессию
                    UserSession().clear();

                    // Переходим на экран логина
                    Navigator.pushReplacement(
                      context, 
                      MaterialPageRoute(builder: (context) => ScreenLogin())
                    );
                  },
                  // Логика функции закрытия меню
                  onClose: () => overlayEntry?.remove(),
                ),  
        )
      )
    );
  }
}