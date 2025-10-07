// page_home.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/services/service_user_session.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:qr_flutter/qr_flutter.dart';
import 'services/service_common.dart';

class PageHome extends StatelessWidget {
  const PageHome({super.key});

  @override
  Widget build(BuildContext context) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    return Container(
      margin: appContainerMargin,
      width: MediaQuery.widthOf(context),
      decoration: BoxDecoration(
        color: colorScheme.surface
      ),
      child: Column(
        children: [
          Row(
            children: [
              Text(
                "Здравствуйте,", 
                style: themeData.textTheme.displayMedium?.apply(
                  color: colorScheme.onSurface
                )
              ),
              SizedBox(width: 5),
              Text(
                UserSession().displayName ?? "Не определено",
                style: themeData.textTheme.displaySmall?.apply(
                  color: colorScheme.onSurface
                ),
              )
            ]
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
                UserSession().cardNumber == 0 ? 
                  "Не определен" : 
                  UserSession().cardNumber.toString(),
                  style: themeData.textTheme.displaySmall?.apply(
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
            padding: appContainerPadding,
            decoration: BoxDecoration(
              borderRadius: appContainerBorderRadius,
              color: colorScheme.surfaceContainerLowest
            ),
            child: QrImageView(
              // Генерируем QR, используя закодированные данные о карте
              data: 'esvcard:${ServiceCommon.encodeCardData(
                cardCode: UserSession().cardCode ?? 0,
                accountNumber: UserSession().accountNumber ?? 0,
                cardQrDatetime: ServiceCommon.genDateTime()
              )}',
              version: QrVersions.auto,
              size: 50,
              backgroundColor: Colors.transparent,
            ),
          ),
        ],
      ),
    );
  }
}