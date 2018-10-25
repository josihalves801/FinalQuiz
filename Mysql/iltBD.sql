CREATE DATABASE IF NOT EXISTS quiz;
USE quiz;

CREATE TABLE IF NOT EXISTS pergunta(
	id_perg INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pergunta TEXT,
    categoria INT,
    dica TEXT
);

CREATE TABLE IF NOT EXISTS resposta(
	id_resp INT UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fk_perg INT NOT NULL,
    CONSTRAINT fk_perg FOREIGN KEY (fk_perg) REFERENCES pergunta(id_perg),
    resposta TEXT,
    correta BOOL
);

INSERT INTO pergunta (id_perg, pergunta, categoria, dica) VALUES 
(1, '1) Em que período ocorreu a Primeira Guerra Mundial?', 1),
(2, '2) A primeira guerra mundial foi centrada em qual continente?', 1, ),
(3, '3) Qual desses fatores foi o estopim para ocorrer a Primeira Guerra Mundial?
', 1),

(4, '4) Quais eram as duas maiores potências da época?
', 1, 
),
(5, '5) Qual o acontecimento que em 1871 veio alterar o equilíbrio europeu?
', 1, ),
(6, '6) Quais eram o nome da aliança da Rússia, Alemanha e Aústria - Hungria antes da guerra?
', 1),
(7, '7) Qual o acontecimento que em 1871 veio alterar o equilíbrio europeu?
 
', 1),
(8, '8) Com base em seus conhecimentos prévios sobre a 1ª Guerra Mundial, leia as afirmações abaixo, reflita sobre quais são falsas e quais são verdadeiras e assinale a alternativa correta:
 
I) A incapacidade dos Estados liberais em solucionar a crise econômica do século XIX colocou em xeque toda a estrutura do sistema capitalista. A instabilidade política e social das nações europeias impulsionou as disputas colonialistas e o conflito entre as potências.
 
II) A desigualdade de desenvolvimento das nações capitalistas europeias acentuou a rivalidade imperialista. A disputa colonial marcada por um nacionalismo agressivo e pela corrida armamentista expandiu os pontos de atrito entre as potências.
 
III) O sucesso da política de apaziguamento e do sistema de aliança equilibrou o sistema de forças entre as nações europeias, acirrando as lutas de conquista das colônias da África e da Ásia.
 
IV) O expansionismo na Áustria, a invasão da Polônia pelas tropas alemãs assustaram a Inglaterra e a França, que reagiram contra a agressão declarando guerra ao inimigo.
 
V) O desequilíbrio entre a produção e consumo incentivou a conquista de novos mercados produtores de matérias-primas e consumidores de bens de produção reativando as rivalidades entre os países europeus e os da América do Norte.
 

', 1, ''),
(9, ' 
9) Analise as proposições que se referem ao período entre a I e a II Guerra Mundial na Europa, e marque (V) para verdadeira e (F) para falsa.
 
( ) As condições do tratado de paz que encerrou a I Guerra Mundial e obrigou a Alemanha a pagar pesadas indenizações de guerra foi um dos fatores que contribuiu para a ascensão do partido de Adolf Hitler ao poder.
( ) Com a necessidade dos homens irem para o front de guerra, as mulheres foram convocadas a trabalhar em postos de trabalhos, normalmente ocupados pelos homens, como por exemplo, nas indústrias metalúrgicas e de armamentos.
( ) O período do entre guerras foi marcado por revoltas e greves dos trabalhadores em muitos países europeus, devido às condições de trabalho e à carestia. Em muitos países este foi um fator que levou governos autoritários e nacionalistas ao poder.
( ) Este período foi marcado pelo surgimento da televisão, meio de comunicação que foi muito utilizado pelos governantes para fazer propaganda de suas políticas sociais durante a II Guerra Mundial.
 
Assinale a alternativa que contém a sequência correta, de cima para baixo.
', 1),
(10, '10) O fim da I Guerra Mundial trouxe, entre outras conseqüências:
', 1),
(11, '1) Com a ida dos homens aos campos de batalhas para lutar pelo seu país, as mulheres tiveram uma grande importância na época. Algumas dessas realizações mais importantes que outras. Uma das mais importantes foi a conquista do direito de:
 
', 2),
(12, 'A Europa era um "barril de pólvora", segundo diversas fontes, qual era o local que denominamos de "pavil"?
 
', 2),
(13, '3) Qual foi a data que o Arquiduque foi assassinado?
', 2),
(14, '4) Além da Europa estar em guerra quais outros locais, ao mesmo tempo, estavam em conflito?
', 2),
(15, '5) Qual era o país que estava dominando o Oceano Pacífico?
', 2),
(16, '6) Quem foi Bismarck?
', 2),
(17, '7) Presidente dos Estados Unidos durante a Guerra de 1914 - 1918:
', 2),
(18, '8) Qual dos itens abaixo NÃO está ligado à 1ª Guerra Mundial enquanto causa?
', 2),
(19, '9) O Brasil quando entrou na guerra lutou em qual lado da guerra ? Antes de responder a pergunta considere o texto. o vapor brasileiro "Paraná", que navegava de acordo com as exigências feitas a países neutros, foi torpedeado, supostamente por um submarino alemão. No dia 11 de abril o Brasil rompeu relações diplomáticas com os países do bloco liderado pela Alemanha. Em 20 de maio, o navio "Tijuca" foi torpedeado perto da costa francesa. Nos meses seguintes, o governo Brasileiro confiscou 42 navios alemães, austro-húngaros e turco-otomanos que estavam em portos brasileiros.
', 2),
(20, '10) Quem era o presidente do Brasil durante a primeira guerra mundial?
 
', 2),
(21, '1) Qual foi o país que mais se beneficiou com a 1º guerra mundial?
 
', 3),
(22, '2) Mídias que expandiram na Europa após guerra Mundial?
', 3),
(23, '3) Qual é nome do acordo que no qual, a Alemanha concordava em devolver as terras que havia dominado e retirar suas tropas delas, além de pagar indenizações aos países vencedores?
', 3),
(24, '4) Assinale a alternativa que, respectivamente, completa as lacunas:
 
Na segunda metade do século ______, a junção entre _______ e capitalismo ______ proporcionou a integração __________ mundial, favorecendo assim, principalmente, as nações que haviam começado seu processo de _____.
', 3),
(25, '5) Assinale a alternativa que, respectivamente, completa as lacunas:
 
A guerra gerou aproximadamente ____________________ milhões de mortos, o _______________________ de feridos, arrasou ____________________ , destruiu ________________, além de gerar grandes prejuízos ___________________ em todos os países envolvidos.
 
', 3),
(26, '6) Além do assassinato do Arquiduque Francisco Ferdinando, teve outros fatores para a "explosão da guerra". Assinale a alternativa correta:
 
', 3),
(27, '7) Na Primeira Guerra Mundial, tinha algumas palavras que não eram usadas no dia-a-dia. Entre elas a palavra "conchie" se referia a o que?
 
', 3),
(28, '8) Sobre Nacionalismos responda esta e a próxima questão.No que consiste o Pan-eslavismo ?', 3),
(29, '9) Qual dos países abaixo NÃO esta alinhado com as chamadas "Potências Centrais" durante a I Grande Guerra?
 
', 3),
(30, '10) Ainda sobre o Nacionalismo, responda: no que consiste o Pangermanismo?
?', 3),


INSERT INTO resposta (fk_perg, resposta, correta) VALUES 
(1, 'Capacete', false),
(1, 'Chave inglesa', false),
(1, 'Matraca', false),
(1, 'Pá de trincheira', true),
(1, 'Campos abertos', false),
(2, 'Construções', false),
(2, 'Trincheiras', true),
(2, 'Veículos', false),
(2, 'Metralhadora', true),
(2, 'Pistola', false),
(3, 'Rifle', false),
(3, 'Lança chamas', false),
(3, 'Blindados', false),
(3, 'Cavalaria', false),
(3, 'Infantaria', true),
(4, 'Artilharia', false),
(4, 'Glock P18C', false),
(4, 'Luger P08', true),
(4, 'Tecnam P92', false),
(4, 'AUG A3', false),
(5, 'Russo', false),
(5, 'Alemão', false),
(5, 'Inglês', true),
(5, 'Chinês', false),
(5, 'Péricles', false),
(6, 'Glicerina', false),
(6, 'Baratol', true),
(6, 'Pólvora', false),
(6, 'Para cometer suicídio caso fosse abatido', true),
(6, 'Para auto-defesa', false),
(7, 'Para abater pilotos inimigos', false),
(7, 'Para se sentir seguro', false),
(7, '150-450 tiros por minuto', false),
(7, '600-900 tiros por minuto', false),
(7, '450-600 tiros por minuto', true),
(8, '450-900 tiros por minuto', false),
(8, 'Oxigênio', false),
(8, 'Hidrogênio', true),
(8, 'Gás carbônico', false),
(8, 'Gás cloro', false),
(9, 'Mark I', true),
(9, 'Renault FT', false),
(9, 'Mark II', false),
(9, 'Char 2C', false),
(9, 'Carros armados', false),
(10, 'Trens blindados', true),
(10, 'Aviões com escolta armada', false),
(10, 'Nenhuma das opções', false),
(10, 'Itália', false),
(10, 'Alemanha', false),
(11, 'Reino Unido', true),
(11, 'França', false),
(11, 'Foi o maior tanque desenvolvido', false),
(11, 'Era movido a vapor', false),
(11, 'Era muito leve pois possuía uma estrutura esquelética', false),
(12, 'Era movido a gás', true),
(12, 'Combate aéreo', false),
(12, 'Bombardeio', false),
(12, 'Destruição de veículos', false),
(12, 'Reconhecimento', true),
(13, 'Reconhecimento fotográfico, localização inimiga e patrulha de contato', true),
(13, 'Reconhecimento de veículos blindados, localização inimiga e patrulha de contato', false),
(13, 'Reconhecimento fotográfico, localização inimiga e patrulha de bombardeio', false),
(13, 'Reconhecimento fotográfico, assistência combatendo inimigos e patrulha de contato', false),
(13, 'Reconhecimento', false),
(14, 'Transporte de soldados', false),
(14, 'Transporte de armas', false),
(14, 'Bombardeio', true),
(14, 'A7V, Char 2C e Mark I', true),
(14, 'Mark I, Holt e Universal Carrier', false),
(15, 'Holt, Char 2C e Somua S35', false),
(15, 'Char 2C, A7V e Matilda A12', false),
(15, 'Granadas, morteiros e tijolos', true),
(15, 'Facas, morteiros e granadas', false),
(15, 'Bomba de fumaça, facas e morteiros', false),
(16, 'Tijolos, granadas e bomba de fumaça', false),
(16, 'Etanol', false),
(16, 'Gasolina', false),
(16, 'Vapor', true),
(16, 'Água', false),
(17, '1912 - 1916', false),
(17, '1914 - 1918', true),
(17, '1916 - 1920', false),
(17, '1910 - 1918', false),
(17, 'França, EUA e Alemanha', false),
(18, 'EUA, Rússia e Império Otomano', false),
(18, 'Inglaterra, França e Alemanha', false),
(18, 'Inglaterra, França e Rússia', true),
(18, 'O assassinato de Francisco Ferdinando', true),
(18, 'A invasão dos EUA à Alemanha', false),
(19, 'A busca desenfreada por territórios', false),
(19, 'Nenhuma das opções', false),
(19, 'Estados Unidos e França', false),
(19, 'Japão e França', false),
(19, 'Japão e Itália', false),
(20, 'Estados Unidos e Japão', true),
(20, 'O massacre da Bélgica', false),
(20, 'A grande devastação belga', false),
(20, 'O estupro da Bélgica', true),
(20, 'Nenhuma das opções', false),
(21, 'O acordo que a Alemanha tinha com os EUA', false),
(21, 'Retomada de territórios conquistados pela Alemanha', false),
(21, 'O ataque da Alemanha à Bélgica', true),
(21, 'O acordo que a Alemanha tinha com os EUA', false),
(21, 'A Inglaterra entrou na guerra', false),
(22, 'Submarinos brasileiros foram abatidos por corvetas alemãs', false),
(22, 'Os EUA entraram na guerra', false),
(22, 'Navios mercantes brasileiros foram abatidos por submarinos alemães', true),
(22, 'Europa', true),
(22, 'América do Sul', false),
(23, 'América do Norte', false),
(23, 'Ásia', false),
(23, 'Guerra dos sete anos', false),
(23, 'Invasão franco-canadense à Alemanha', false),
(23, 'Guerra dos sete dias', false),
(24, 'Invasão austro-húngara à Sérvia', true),
(24, 'A Liga Anti-Guerra', false),
(24, 'A Liga das Nações', true),
(24, 'Organização da paz', false),
(24, 'Organização Mundial', false),
(25, 'Organização Mundial', false)
(25, 'Organização da paz', false),
(25, 'Organização da paz', false),
(25, 'Organização da paz', false),
(25, 'Organização da paz', false),
(26, 'Organização da paz', false),
(26, 'Organização da paz', false),
(26, 'Organização da paz', false),
(26, 'Organização da paz', false),
(26, 'Organização da paz', false),
(27, 'Organização da paz', false),
(27, 'Organização da paz', false),
(27, 'Organização da paz', false),
(27, 'Organização da paz', false),
(27, 'Organização da paz', false),
(28, 'Organização da paz', false),
(28, 'Organização da paz', false),
(28, 'Organização da paz', false),
(28, 'Organização da paz', false),
(28, 'Organização da paz', false),
(29, 'Organização da paz', false),
(29, 'Organização da paz', false),
(29, 'Organização da paz', false),
(29, 'Organização da paz', false),
(29, 'Organização da paz', false),
(29, 'Organização da paz', false),
(30, 'Organização da paz', false),
(30, 'Organização da paz', false),
(30, 'Organização da paz', false),
(30, 'Organização da paz', false),
(30, 'Organização da paz', false);


