#!/bin/bash

clear

while true; do
    echo "Registro de Inicio de Sesión - CentOS"
    echo "--------------------------------------"
    echo "1. Mostrar registros de inicio de sesión SSH exitosos"
    echo "2. Mostrar registros de inicio de sesión SSH fallidos"
    echo "3. Mostrar registros de inicio de sesión local"
    echo "4. Mostrar los últimos registros de inicio de sesión"
    echo "5. Buscar registros por nombre de usuario"
    echo "6. Salir"
    echo "--------------------------------------"

    read -p "Seleccione una opción: " opcion

    case $opcion in
        1)
            clear
            echo "Registros de inicio de sesión SSH exitosos:"
            cat /var/log/secure | grep "sshd.*Accepted"
            read -p "Presiona Enter para continuar..."
            ;;
        2)
            clear
            echo "Registros de inicio de sesión SSH fallidos:"
            cat /var/log/secure | grep "sshd.*Failed"
            read -p "Presiona Enter para continuar..."
            ;;
        3)
            clear
            echo "Registros de inicio de sesión local:"
            cat /var/log/messages | grep "login"
            read -p "Presiona Enter para continuar..."
            ;;
        4)
            clear
            echo "Últimos registros de inicio de sesión:"
            tail /var/log/secure /var/log/messages
            read -p "Presiona Enter para continuar..."
            ;;
        5)
            clear
            read -p "Introduce el nombre de usuario: " usuario
            echo "Registros para el usuario $usuario:"
            grep -e "sshd.*Accepted" -e "sshd.*Failed" /var/log/secure | grep "$usuario"
            grep "login" /var/log/messages | grep "$usuario"
            read -p "Presiona Enter para continuar..."
            ;;
        6)
            clear
            echo "Saliendo..."
            exit 0
            ;;
        *)
            clear
            echo "Opción no válida. Intente nuevamente."
            ;;
    esac
done
