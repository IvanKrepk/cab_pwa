// services.service_ui.dart
import 'package:flutter/material.dart';
import 'package:flutter_cab_pwa/styles/styles_shapes.dart';

class ServiseUI {

  // Процедура отображения всплывающих виджетов поверх экрана
  static OverlayEntry showOverlayWidget(
    BuildContext context,
    Widget overlayWidget,                                   // Виджет, который будет отображаться 
    [Color? modalBarrierColor = Colors.transparent]       // Цвет фона, окружающего overlayWidget
  ) {
    OverlayEntry? overlayEntry;
    overlayEntry = OverlayEntry(
      builder: (context) {
        return Stack(
          children: [
            // Область фона, при нажатии на которую закрываем всплывающее окно
            ModalBarrier(
              color: modalBarrierColor,
              onDismiss: () => overlayEntry?.remove(),
            ),
            // Отображаем виждет на экране
            overlayWidget
          ]
        );
      }
    );

    Overlay.of(context).insert(overlayEntry);
    return overlayEntry;
  }

  // Процедура отображения сообщения об ошибке
  static void showErrorMessage(
    BuildContext context,
    String? message
  ) {
    final ThemeData themeData = Theme.of(context);
    final ColorScheme colorScheme = themeData.colorScheme;

    showOverlayWidget(
      context, 
      Center(
        child: Column(
          mainAxisSize: MainAxisSize.min, 
          children: [
            ConstrainedBox(
              constraints: BoxConstraints(
                maxWidth: MediaQuery.widthOf(context) * 0.7
              ),
              child: Container(
                padding: appContainerPadding,
                decoration: BoxDecoration(
                  borderRadius: appContainerBorderRadius,
                  border: Border.all(
                    width: 3,
                    color: colorScheme.error,
                  ),
                  color: colorScheme.errorContainer,
                ),
                child: Center(
                  child: Text(
                    textAlign: TextAlign.center,
                    message ?? 'Ошибка не распознана',
                    style: themeData.textTheme.labelLarge?.apply(
                      color: colorScheme.error,
                    ),
                  ),
                ),
              ),
            )
          ],
        ),
      ),
      Color.fromARGB(150, 0, 0, 0)
    );
  }
}