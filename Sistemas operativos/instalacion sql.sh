rpm -Uvh https://repo.mysql.com/mysql80-community-release-el7-3.noarch.rpm
sed -i 's/enabled=1/enabled=0/' /etc/yum.repos.d/mysql-community.repo
rpm --import https://repo.mysql.com/RPM-GPG-KEY-mysql-2022
yum -y --enablerepo=mysql80-community install mysql-community-server
systemctl start mysqld
systemctl enable mysqld
echo skip-grant-tables >> /etc/my.cnf
systemctl restart mysqld
mysql -u root -proot -e "FLUSH PRIVILEGES; UNINSTALL COMPONENT 'file://component_validate_password'; ALTER USER root@localhost IDENTIFIED BY 'root';"
sed -i '/skip-grant-tables/d' '/etc/my.cnf'
systemctl restart mysqld


