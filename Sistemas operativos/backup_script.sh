#!/bin/bash


#Script para uso de parametro $1 en linea crontab  (IP DE EJEMPLO)

# BACKUP SSH
if [ "$1" == "ssh" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf ssh_config_$fecha_actual.tar.gz /etc/ssh/
 mkdir -p /root/backups/ssh_config_backups/
 rsync -avz ssh_config_$fecha_actual.tar.gz root@localhost:/root/backups/ssh_config_backups/


fi

# BACKUP BASE DE DATOS
if [ "$1" == "bd" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 mysqldump -u root -proot QUICKCARRY > bdQUICKCARRY.sql
 tar -czvf bdQUICKCARRY_$fecha_actual.tar.gz /root/bdQUICKCARRY.sql
 mkdir -p /root/backups/bd/   
 rsync -avz bdQUICKCARRY_$fecha_actual.tar.gz root@localhost:/root/backups/bd/
  
fi

# SCRIPTS PERSONALIZADOS Y CONFIGURACION DE INICIO (BASHRC)
if [ "$1" == "scripts_bashrc" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf bashrc_$fecha_actual.tar.gz /root/.bashrc
 mkdir -p /root/backups/bashrc/  
 rsync -avz  bashrc_$fecha_actual.tar.gz root@localhost:/root/backups/bashrc/


 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf scripts_personalizados_$fecha_actual.tar.gz /root/scripts/
 mkdir -p /root/backups/bashrc/   
 rsync -avz scripts_personalizados_$fecha_actual.tar.gz root@localhost:/root/backups/bashrc/

    
fi
