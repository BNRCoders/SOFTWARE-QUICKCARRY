#!/bin/bash

# Generar un par de claves SSH RSA
ssh-keygen -t rsa -b 2048 -f /root/id_rsa -N ''

# Habilitar PermitRootLogin en el archivo sshd_config
sed -i 's/#PermitRootLogin.*/PermitRootLogin yes/' /etc/ssh/sshd_config

# Deshabilitar PasswordAuthentication en el archivo sshd_config
sed -i 's/^PasswordAuthentication.*/PasswordAuthentication no/' /etc/ssh/sshd_config

# Habilitar PubkeyAuthentication en el archivo sshd_config
sed -i 's/^#PubkeyAuthentication.*/PubkeyAuthentication yes/' /etc/ssh/sshd_config

# Reiniciar el servicio SSH
systemctl restart sshd

# Copiar la clave SSH pÃºblica del usuario local a Authorized_Keys del "usuario remoto".
cat /root/id_rsa.pub >> /root/.ssh/authorized_keys


#En este caso, copie la clave de mi propio usuario, pero en cualquier caso, copiariamos las claves de aquellos que queramos que tengan acceso.
