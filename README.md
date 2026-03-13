Actividad para la clase de CIBERINFRESTRUCTURA.

Validador de Contraseñas Seguras (Windows Forms).

Este proyecto es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Su objetivo principal es gestionar la creación y validación de contraseñas, asegurando que cumplan con estándares modernos de seguridad mediante el uso de expresiones regulares (Regex).

/Funcionalidades/

1. Ocultación Automática: Los campos de texto protegen la privacidad del usuario convirtiendo los caracteres en asteriscos (*) en tiempo real.

2. Validación Robusta: Implementa un sistema de verificación que exige requisitos de complejidad específicos.

3. Confirmación de Coincidencia: Compara dos campos para asegurar que el usuario ha ingresado la misma contraseña correctamente.

4. Retroalimentación Visual: Utiliza cuadros de mensaje (MessageBox) con iconos de éxito, advertencia o error según el resultado.

/Requisitos de Seguridad/

Para que una contraseña sea considerada válida por el sistema, debe cumplir con los siguientes criterios:

1. Mínimo 8 caracteres de longitud.

2. Al menos una letra mayúscula.

3. Al menos una letra minúscula.

4. Al menos un número.

5. Al menos un carácter especial (símbolo).

/Explicación Técnica/

El núcleo de la validación reside en el método ValidarContrasena, que utiliza la siguiente expresión regular:

C#

"string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";"

Desglose del Regex:

1. (?=.*[a-z]): Busca al menos una minúscula.

2. (?=.*[A-Z]): Busca al menos una mayúscula.

3. (?=.*\d)   : Busca al menos un dígito.

4. (?=.*[^\da-zA-Z]): Busca al menos un carácter que no sea alfanumérico (símbolo).

5. .{8,}      : Define la longitud mínima de 8 caracteres.

/¿Cómo usarlo?/

1. Ingresa tu contraseña en el primer campo.

2. Repítela en el segundo campo para confirmar.

3. Haz clic en el botón de validar para obtener el diagnóstico del sistema.
