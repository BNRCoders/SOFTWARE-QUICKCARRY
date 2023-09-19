#!/bin/bash


#Script para uso de parametro $1 en linea crontab  (IP DE EJEMPLO)

# BACKUP SSH
if [ "$1" == "ssh" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf ssh_config_$fecha_actual.tar.gz /etc/ssh/
 sshpass -p 'root' ssh root@192.168.1.11 "mkdir -p /root/backups/ssh_config_backups/"   # En la hora de un uso real, un copiado de claves rsa seria lo ideal, antes que usar sshpass
 rsync -avz -e "sshpass -p 'root' ssh" ssh_config_$fecha_actual.tar.gz root@192.168.1.11:/root/backups/ssh_config_backups/


fi

# BACKUP BASE DE DATOS
if [ "$1" == "bd" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 mysqldump -u root -proot QUICKCARRY > bdQUICKCARRY.sql
 tar -czvf bdQUICKCARRY_$fecha_actual.tar.gz /root/bdQUICKCARRY.sql
 sshpass -p 'root' ssh root@192.168.1.11 "mkdir -p /root/backups/bd/"   # En la hora de un uso real, un copiado de claves rsa seria lo ideal, antes que usar sshpass
 rsync -avz -e "sshpass -p 'root' ssh" bdQUICKCARRY_$fecha_actual.tar.gz root@192.168.1.11:/root/backups/bd/
  
fi

# SCRIPTS PERSONALIZADOS Y CONFIGURACION DE INICIO (BASHRC)
if [ "$1" == "scripts_bashrc" ]; then

 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf bashrc_$fecha_actual.tar.gz /root/.bashrc
 sshpass -p 'root' ssh root@192.168.1.11 "mkdir -p /root/backups/bashrc/"   # En la hora de un uso real, un copiado de claves rsa seria lo ideal, antes que usar sshpass
 rsync -avz -e "sshpass -p 'root' ssh" bashrc_$fecha_actual.tar.gz root@192.168.1.11:/root/backups/bashrc/


 fecha_actual=$(date +"%d_%m_%Y")
 tar -czvf scripts_personalizados_$fecha_actual.tar.gz /root/scripts/
 sshpass -p 'root' ssh root@192.168.1.11 "mkdir -p /root/backups/bashrc/"   # En la hora de un uso real, un copiado de claves rsa seria lo ideal, antes que usar sshpass
 rsync -avz -e "sshpass -p 'root' ssh" scripts_personalizados_$fecha_actual.tar.gz root@192.168.1.11:/root/backups/bashrc/

    
fi
