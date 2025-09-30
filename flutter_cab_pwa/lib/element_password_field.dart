// element_password_field
import 'package:flutter/material.dart';

class ElementPasswordField extends StatefulWidget {
  const ElementPasswordField({super.key, this.style});

  final TextStyle? style;

  @override
  State<StatefulWidget> createState() {
    return _ElementPasswordFieldState();
  }
  
}

class _ElementPasswordFieldState extends State<ElementPasswordField> {

  // Отображать пароль или не отображать
  bool _isPasswordVisible = false;

  @override
  Widget build(BuildContext context) {
    return TextField(
      style: widget.style,
      obscureText: !_isPasswordVisible,
      decoration: InputDecoration(
        suffixIcon: IconButton(
          icon: Icon(
            (_isPasswordVisible != true) ? Icons.visibility : Icons.visibility_off
          ),
          onPressed: () {
            setState(() {
              _isPasswordVisible = !_isPasswordVisible;
            });
          }
        )
      ),
    );
  }
}