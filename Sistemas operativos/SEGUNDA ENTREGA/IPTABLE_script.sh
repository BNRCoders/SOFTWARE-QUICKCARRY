iptables -A INPUT -p tcp --dport 22 -j ACCEPT      #HABILITA PUERTO 22
  
iptables -A INPUT -j LOG --log-prefix "IPTABLES DENIED: " #REGISTRA INTENTOS FALLIDOS

iptables -A INPUT -p tcp --dport 22 -m conntrack --ctstate NEW -m recent --set
iptables -A INPUT -p tcp --dport 22 -m conntrack --ctstate NEW -m recent --update --seconds 60 --hitcount 4 -j DROP          #LIMITA CANTIDAD DE INTENTOS POR MINUTO

