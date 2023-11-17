#!/bin/bash

while true; do
    echo "1. Ver redes"
    echo "2. Configuracion de red"
    echo "3. Salir"

    read -p "Selecciona una opcion: " opcion

    case $opcion in
        1)
            echo "Listado de redes:"
            nmcli
            ;;
        2)
            echo "Configuracion de red:"
            nmtui
            ;;
        3)
            echo "Saliendo del script."
            exit 0
            ;;
        *)
            echo "Opcion no valida. Por favor, selecciona una opcion valida."
            ;;
    esac
done
