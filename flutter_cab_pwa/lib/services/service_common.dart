// services/service_common.dart
import 'dart:convert';

class ServiceCommon {

  // Функция получения текущего времени
  static int genDateTime() {
    // Получаем текущее время в UTC
    final now = DateTime.now().toUtc();

    // Форматируем как YYYYMMDDHHmm и преобразуем в int
    final formatted = '${now.year}${_formatTwoDigits(now.month)}${_formatTwoDigits(now.day)}${_formatTwoDigits(now.hour)}${_formatTwoDigits(now.minute)}';

    return int.parse(formatted);
  }

  // Вспомогательная функция для добавления ведущего нуля
  static String _formatTwoDigits(int n) {
    return n.toString().padLeft(2, '0');
  }

  static String encodeCardData({int cardCode = 0, int accountNumber = 0, int? cardQrDatetime}) {
    final code = cardCode;
    final num = accountNumber;
    final qrDt = cardQrDatetime;

    if (num == 0) {
      return "Номер карты не может быть 0";
    }

    if (qrDt == null) {
      return "Дата QR-кода не может быть null";
    }

    final str = '$code-$num#$qrDt';
    const xorKey = 0x31; // 49 в десятичной

    final StringBuffer result = StringBuffer();
    for (int i = 0; i < str.length; i++) {
      // Получаем код символа, XOR-им с ключом, преобразуем обратно в символ
      result.write(String.fromCharCode(str.codeUnitAt(i) ^ xorKey));
    }

    // Преобразуем строку в массив байт и затем в hex-строку
    final bytes = utf8.encode(result.toString());
    return _bytesToHex(bytes);
  }

  // Вспомогательная функция для преобразования List<int> в hex-строку
  static String _bytesToHex(List<int> bytes) {
    final buffer = StringBuffer();
    for (int byte in bytes) {
      buffer.write(byte.toRadixString(16).padLeft(2, '0'));
    }
    return buffer.toString();
  }
}