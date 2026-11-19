# Ejercicio1
def ejercicio1():
    for numero in range(1, 101):
        if numero % 3 == 0:
            print(numero)


# Ejercicio2
def ejercicio2():
    edad = int(input("Ingresa tu edad: "))

    if edad < 18:
        print("Sos menor de edad")
    elif edad == 18:
        print("Tenes justo 18 años")
    else:
        print("Sos mayor de edad")


# Ejercicio3
def ejercicio3():
    palabra = input("Ingresa una palabra: ")
    print("Cantidad de letras:", len(palabra))


# Ejercicio4
def ejercicio4():
    contraseña = "python123"
    intentos = 5

    while intentos > 0:
        respuesta = input("Adivina la contraseña: ")

        if respuesta == contraseña:
            print("¡Correcto! Acceso permitido")
            return
        else:
            intentos -= 1
            print("Contraseña incorrecta")
            print("Intentos restantes:", intentos)

    print("Te quedaste sin intentos")


# Ejercicio5
def ejercicio5():
    mayor = None

    for i in range(10):
        numero = float(input("Ingresa un numero: "))

        if mayor is None or numero > mayor:
            mayor = numero

    print("El numero mas alto es:", mayor)


# Ejercicio6
def ejercicio6():
    nombre = input("Ingresa tu nombre: ")
    print("Hola", nombre.title())


# Ejercicio7
def ejercicio7():
    for i in range(1, 11):
        print("7 x", i, "=", 7 * i)


# Ejercicio8
def ejercicio8():
    for i in range(10, 0, -1):
        print(i)

    print("oa")


# Ejercicio9
def ejercicio9():
    numero = int(input("Ingresa un numero: "))

    if numero % 2 == 0:
        print("Par")
    else:
        print("Impar")


# Ejercicio10
def ejercicio10():
    frase = input("Ingresa una frase: ")
    vocales = "aeiouáéíóú"
    contador = 0

    for letra in frase.lower():
        if letra in vocales:
            contador += 1

    print("Cantidad de vocales:", contador)


# Ejercicio11
def ejercicio11():
    numero = int(input("Ingresa un numero: "))

    for i in range(1, 13):
        print(numero, "x", i, "=", numero * i)


# Ejercicio12
def ejercicio12():
    total = 0

    while total <= 100:
        numero = float(input("Ingresa un numero: "))
        total += numero
        print("Total acumulado:", total)

    print("¡Superaste los 100!")


# Ejercicio13
def ejercicio13():
    palabra = input("Ingresa una palabra: ")

    for letra in palabra:
        print(letra)


# Ejercicio14
def ejercicio14():
    edad = int(input("Ingresa tu edad: "))

    puede_votar = edad >= 16
    puede_manejar = edad >= 17

    if puede_votar and puede_manejar:
        print("Podes votar y manejar")
    elif puede_votar:
        print("Podes votar, pero no manejar")
    elif puede_manejar:
        print("Podes manejar, pero no votar")
    else:
        print("No podes votar ni manejar")


# Ejercicio15
def ejercicio15():
    for numero in range(50, -1, -5):
        print(numero)


# Ejercicio16
def ejercicio16():
    while True:
        contraseña1 = input("Ingresa una contraseña: ")
        contraseña2 = input("Repite la contraseña: ")

        if contraseña1 == contraseña2:
            print("Acceso permitido")
            break
        else:
            print("Las contraseñas no coinciden. Intenta nuevamente")


# Ejercicio17
def ejercicio17():
    while True:
        nombre = input("Ingresa un nombre: ")

        if len(nombre) > 10:
            print("El nombre tiene mas de 10 caracteres")
            break
        else:
            print("El nombre es demasiado corto. Intenta nuevamente")

ejercicio1()
ejercicio2()
ejercicio3()
ejercicio4()
ejercicio5()
ejercicio6()
ejercicio7()
ejercicio8()
ejercicio9()
ejercicio10()
ejercicio11()
ejercicio12()
ejercicio13()
ejercicio14()
ejercicio15()
ejercicio16()
ejercicio17()