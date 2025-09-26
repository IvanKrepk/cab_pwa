// screen_main.dart
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'page_home.dart';
import 'page_account.dart';
import 'menu_account.dart';

class ScreenMain extends StatefulWidget {
  const ScreenMain({super.key});

  @override
  State<StatefulWidget> createState() {
    return _StateMainScreen();
  }
}
  
class _StateMainScreen extends State<ScreenMain> {
  
  // Текуший индекс страницы на главном экране
  int _currentIndex = 0;

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
                Text(
                  "Кабинет водителя", 
                  style: themeData.textTheme.headlineSmall?.apply(
                    color: colorScheme.onPrimary
                  )
                )
              ],
            ),
            // Меню аккаунта и настроек
            Row(
              children: [
                // Аккаунт
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
                    _showTopPanel(context);
                  }
                ),
                // Настройки
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
                  onPressed: (){}
                )
              ],
            )
          ],
        ),
      ),
      body: 
        IndexedStack(
        index: _currentIndex,
        children: _pages
      ),
    );
  }

  void _showTopPanel(BuildContext context) {
    double heightAppBar = AppBar().preferredSize.height;
    double heightSystemStatusBar = MediaQuery.of(context).padding.top;

    OverlayEntry? overlayEntry;
    overlayEntry = OverlayEntry(
      builder: (context) {
        return Stack(
          children: [
            ModalBarrier(
              color: Colors.transparent,
              onDismiss: () => overlayEntry?.remove(),
            ),
            Positioned(
              top: heightAppBar + heightSystemStatusBar,
              right: 0,
              child: IntrinsicWidth( // Ключевая обёртка: делает ширину равной самому широкому дочернему элементу
                stepWidth: 56.0, 
                child: MenuAccount(
                  onClose: () => overlayEntry?.remove(),
                )
              )
            )
          ]
        );
      }
    );

    Overlay.of(context).insert(overlayEntry);
  }
}