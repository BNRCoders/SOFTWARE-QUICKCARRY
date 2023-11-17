#!/bin/bash

while true; do
    clear
    echo "Seleccione una opción:"
    echo "1. Crear usuario"
    echo "2. Eliminar usuario"
    echo "3. Modificar usuario"
    echo "4. Crear grupo"
    echo "5. Eliminar grupo y sus usuarios"
    echo "6. Modificar grupo"
    echo "7. Salir"

    read opcion

    case $opcion in
        1) # Crear usuario
            clear
            echo "Ingrese el nombre de usuario:"
            read nuevo_usuario

            echo "Ingrese la contraseña:"
            read -s password

            echo "Grupos disponibles:"
            cut -d: -f1 /etc/group

            echo "Ingrese el nombre del grupo al que desea agregar el usuario:"
            read grupo

            if grep -q "^$grupo:" /etc/group; then
                useradd -m $nuevo_usuario
                echo "$nuevo_usuario:$password" | sudo chpasswd
                usermod -aG $grupo $nuevo_usuario
                 echo "Usuario creado con éxito."
            else
                echo "El grupo no existe. ¿Desea crearlo? (S/N)"
                read opcion_grupo

                if [ $opcion_grupo = "S" ] || [ $opcion_grupo = "s" ]; then
                    groupadd $grupo
                    sleep 1 
                    useradd -m $nuevo_usuario
                    usermod -aG $grupo $nuevo_usuario
                    echo "Usuario creado con éxito."
                else
                    echo "No se ha creado el usuario, el grupo no existe."
                    read -p "Presione una tecla para continuar"
                fi
            fi
           
            read -p "Presione una tecla para continuar"
            ;;

        2) # Eliminar usuario
            clear
            echo "Ingrese el nombre de usuario que desea eliminar:"
            read usuario_eliminar
            clear
            userdel -r $usuario_eliminar
            echo "Usuario eliminado con éxito."
            read -p "Presione una tecla para continuar"
            ;;

        3) # Modificar usuario
            clear
            echo "Ingrese el nombre de usuario que desea modificar:"
            read usuario_modificar
            clear
            echo "Seleccione una opción:"
            echo "a. Modificar nombre de usuario"
            echo "b. Modificar contraseña"
            echo "c. Cambiar de grupo"

            read opcion_modificar

            case $opcion_modificar in
                a) # Modificar nombre de usuario
                    clear
                    echo "Ingrese el nuevo nombre de usuario:"
                    read nuevo_nombre
                    usermod -l $nuevo_nombre $usuario_modificar
                    echo "Nombre de usuario modificado con éxito."
                    read -p "Presione una tecla para continuar"
                    ;;

                b) # Modificar contraseña
                    clear
                    echo "Ingrese la nueva contraseña:"
                    read -s nueva_password
                    echo -e "$nueva_password\n$nueva_password" | passwd $usuario_modificar
                    echo "Contraseña modificada con éxito."
                    read -p "Presione una tecla para continuar"
                    ;;

                c) # Cambiar de grupo
                    clear
                    echo "Grupos disponibles:"
                    cut -d: -f1 /etc/group

                    echo "Ingrese el nuevo grupo para el usuario:"
                    read nuevo_grupo

                    if grep -q "^$nuevo_grupo:" /etc/group; then
                        usermod -aG $nuevo_grupo $usuario_modificar
                        echo "Usuario movido al nuevo grupo con éxito."
                        read -p "Presione una tecla para continuar"
                    else
                        echo "El grupo no existe. ¿Desea crearlo? (S/N)"
                        read opcion_grupo

                        if [ $opcion_grupo = "S" ] || [ $opcion_grupo = "s" ]; then
                            groupadd $nuevo_grupo
                            sleep 1 
                            usermod -aG $nuevo_grupo $usuario_modificar
                            echo "Usuario movido al nuevo grupo con éxito."
                            read -p "Presione una tecla para continuar"
                        else
                            echo "No se ha movido el usuario, el grupo no existe."
                            read -p "Presione una tecla para continuar"
                        fi
                    fi
                    ;;
            esac
            ;;

        4) # Crear grupo
            clear
            echo "Ingrese el nombre del nuevo grupo:"
            read nuevo_grupo
            groupadd $nuevo_grupo
            echo "Grupo creado con éxito."
            read -p "Presione una tecla para continuar"
            ;;

        5) # Eliminar grupo y sus usuarios
            clear
            echo "Ingrese el nombre del grupo que desea eliminar:"
            read grupo_eliminar

            if grep -q "^$grupo_eliminar:" /etc/group; then
                groupdel $grupo_eliminar
                echo "Grupo eliminado con éxito."
                read -p "Presione una tecla para continuar"
            else
                echo "El grupo no existe."
                read -p "Presione una tecla para continuar"
            fi
            ;;

        6) # Modificar grupo
            clear
            echo "Ingrese el nombre del grupo que desea modificar:"
            read grupo_modificar

            echo "Seleccione una opción:"
            echo "a. Cambiar nombre del grupo"
            echo "b. Cambiar permisos del grupo"

            read opcion_grupo_modificar

            case $opcion_grupo_modificar in
                a) # Cambiar nombre del grupo
                    clear
                    echo "Ingrese el nuevo nombre del grupo:"
                    read nuevo_nombre_grupo
                    groupmod -n $nuevo_nombre_grupo $grupo_modificar
                    echo "Nombre del grupo modificado con éxito."
                    read -p "Presione una tecla para continuar"
                    ;;

                b) # Cambiar permisos del grupo
                    clear
                    echo "Ingrese los nuevos permisos del grupo (separados por comas):"
                    read nuevos_permisos_grupo
                    groupmod -P $nuevos_permisos_grupo $grupo_modificar
                    echo "Permisos del grupo modificados con éxito."
                    read -p "Presione una tecla para continuar"
                    ;;
            esac
            ;;

        7) # Salir
            exit 0
            ;;

        *)
            echo "Opción no válida. Por favor, seleccione una opción del 1 al 7."
            read -p "Presione una tecla para continuar"
            ;;

    esac
done
