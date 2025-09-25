// home_screen.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:qr_flutter/qr_flutter.dart';

class HomeScreen extends StatelessWidget {
  const HomeScreen({super.key});

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
            Row(
              children: [
                IconButton(
                  onPressed: (){},
                  icon: SvgPicture.asset(
                    "assets/user_icon.svg",
                    width: 40,
                    height: 40,
                    colorFilter: ColorFilter.mode(
                      colorScheme.onPrimary, 
                      BlendMode.srcIn
                    ),
                  ),
                ),
                SizedBox(width: 20),
                IconButton(
                  onPressed: (){},
                  icon: SvgPicture.asset(
                    "assets/menu_icon.svg",
                    width: 40,
                    height: 40,
                    colorFilter: ColorFilter.mode(
                      colorScheme.onPrimary, 
                      BlendMode.srcIn
                    ),
                  )
                )
              ],
            )
          ],
        ),
      ),
      body:
      Container(
        margin: EdgeInsets.symmetric(horizontal: 10, vertical: 20),
        width: MediaQuery.widthOf(context),
        decoration: BoxDecoration(
          color: colorScheme.surface
        ),
        child: Column(
          children: [
            Text(
              "Здравствуйте", 
              style: themeData.textTheme.displayMedium?.apply(
                color: colorScheme.onSurface
              )
            ),
            SizedBox(height: 10),
            Row(
              children: [
                SvgPicture.asset(
                  "assets/card_icon.svg",
                  width: 40, height: 40,
                  colorFilter: ColorFilter.mode(
                    colorScheme.onSurface, 
                    BlendMode.srcIn
                  ),
                ),
                SizedBox(width: 5),
                Text(
                  "709",
                  style: themeData.textTheme.displayMedium?.apply(
                    color: colorScheme.onSurface
                  ),
                )
              ]
            ),
            SizedBox(height: 10),
            Row(
              children: [
                SvgPicture.asset(
                  "assets/qr_icon.svg",
                  width: 40, height: 40,
                  colorFilter: ColorFilter.mode(
                    colorScheme.onSurface, 
                    BlendMode.srcIn
                  ),
                ),
                SizedBox(width: 5),
                Text(
                  "QR-Код",
                  style: themeData.textTheme.displayMedium?.apply(
                    color: colorScheme.onSurface
                  ),
                )  
              ],
            ),
            Align(
              alignment: Alignment.centerLeft,
              child: Text(
                "Покажите его оператору",
                style: themeData.textTheme.bodyLarge,
              )
            ),
            SizedBox(height: 10),
            Container(
              width: 300,
              height: 300,
              padding: EdgeInsets.all(20),
              decoration: BoxDecoration(
                borderRadius: appContainerBorderRadius,
                color: colorScheme.surfaceContainerLowest
              ),
              child: QrImageView(
                data: "Demo",
                version: QrVersions.auto,
                size: 50,
                backgroundColor: Colors.transparent,
              ),
            ),
          ],
        ),
      )
    );
  }
}