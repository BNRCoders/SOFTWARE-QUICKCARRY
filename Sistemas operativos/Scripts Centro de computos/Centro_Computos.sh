#!/bin/bash
while true; do
    clear
    echo "Menu:"
    echo "1. Logs del sistema"
    echo "2. Backup del sistema (ESTABLECER REGLAS CRON DE BACKUP)"
    echo "3. Configuracion de ssh"
    echo "4. Configuracion de firewall mediante iptable"
    echo "5. Gestion de usuarios"
    echo "6. Gestion de red"
    echo "7. Salir"

    read -p "Elije una opcion: " opcion

    case $opcion in
    1)
        clear
        sh /root/logs_script.sh
        ;;
    2)
        clear
 
        crontab /root/CRONTAB_backup.txt
        
        
        ;;
    3)
        clear
        
       ansible-playbook playbook_ssh_custom.yml

        ;;
    4)
        clear
        
        sh /root/IPTABLE_script.sh
        
        ;;

    5)
    clear
       sh /root/usuarios_script.sh

      ;;  
    6) 
        clear
        sh /root/script_red.sh
        ;;
    7)
        clear
        echo "Saliendo del men�..."
        exit 0
        ;;
    *)
        clear
        echo "Opci�n inv�lida. Por favor, selecciona una opci�n v�lida (1-5)."
        ;;
    esac

    read -p "Presiona Enter para continuar..."
done
