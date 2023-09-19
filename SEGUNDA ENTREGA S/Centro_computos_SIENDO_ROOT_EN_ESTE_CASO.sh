#!/bin/bash
while true; do
    clear
    echo "Menu:"
    echo "1. Logs del sistema"
    echo "2. Backup del sistema (ESTABLECER REGLAS CRON DE BACKUP)"
    echo "3. Configuracion de ssh"
    echo "4. Configuracion de firewall mediante iptable"
    echo "5. Salir"

    read -p "Elije una opción: " opcion

    case $opcion in
    1)
        clear
        sh /root/logs_script.sh
        ;;
    2)
        clear
 
        crontab CRONTAB_backup.txt
        
        
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
        echo "Saliendo del menú..."
        exit 0
        ;;
    *)
        clear
        echo "Opción inválida. Por favor, selecciona una opción válida (1-5)."
        ;;
    esac

    read -p "Presiona Enter para continuar..."
done
