#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
int main()
{
	int seguindo,postagem;
	float comecoseguidores = 1.5,  agoraseguidores = 13.5;
	double atuaislikes = 13.6, velhoslikes = 2.4;
	string nome ;

	cout << "Ola Mirabel, aconteceram atualizaçoes em suas midias, entre com o seu nome de usuario: " << endl;
	cin >> nome ;
	cout << "Entre com a sua quantidade de postagens e qunatas pessoas voce segue, separadas por um enter: " << endl;
	cin >> postagem;
	cin >> seguindo;
	cout << "Atualmente voce tem 13,5 milhoes de seguidores e a um mes atras voce tinha 1,5 milhao, existe esta diferença de seguidores entre antes e agora:" << (agoraseguidores - comecoseguidores) << endl;
	cout << "E a sua diferença de seguidors do começo do mes e de agora é de: " << (agoraseguidores - comecoseguidores) << endl;
	cout << "O seu nome de usuario é: " << nome << endl;
	cout << "Voce tem esse numero de postagens :" << postagem << endl;
	cout << "Voce segue esse numero de pessoas: " << seguindo << endl;
}
