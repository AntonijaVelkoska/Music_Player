# Music_Player
Тема на проектната задача и начин на користење

Темата на нашата проектна задача е апликација чија што првична улога е да даде предлог на песна според одредени избори, а освен тоа може да се однесува како обичен плеер за музика. Музиката која што се пушта се дели на неколку категории и тоа:
1.	Амбиентална музика односно музика за позадина
2.	Музика за спиење која понатаму се дели на уште две категории, и тоа
  2.1.	ASMR
     2.1.1.	No talking ASMR
     2.1.2.	Talking ASMR
   2.2.	Instrumental music
    2.2.1.	Classical music
    2.2.2.	Modern music

Мени каде што се пушта музика

Секоја од крајните категории во нашата апликација е поврзана со база од песни која што соодветствува на соодветниот опис. Кога корисникот ќе ја одбере категоријата на песни што сака да биде пуштена има две опции: Play и Random, кои што се наоѓаат на десно заедно со уште две копчиња Stop и Back, додека на лево се наоѓа листа од песните за таа дадена категорија. 
•	Главната идеа на нашиот проект беше копчето Random, односно од дадена листа на песни плеерот да пушти една по негов избор.
•	Копчерто Play има слична фукција како претходното само што пушта песна која што е одбрана од листата на лево.
•	Копчето Stop се користи за да се запре музиката без разлика како е пуштена.
•	Копчето Back го враќа корисникот само кон менито пред него, не до главното мени.
На долниот дел од овој прозорец имаме текстуално поле каде што се прикажува песната која што се пушта во моментот.

Главно мени

На почетното мени на нашата апликација на корисникот му се дава избор од двете главни категории на музика, кои беа наведени претходно.

Мени за бирање на подкатегорија

Откако корисникот ќе одбере категорија од главното мени се јавува мени на подкатегорија во зависност од претходниот избор. Тука има 3 копчиња, две кои водат кон следното мени и едно што води назад кон претходното.


Објаснување на решението

Главната точка во нашиот проект е namespaceот System.Media. Ова го користиме бидејќи ни овозможува едноставна манипулација со песни, што ни е потребно за нашата апликација. Имаше избор да користиме директен медиа плеер од ToolBox, меѓутоа тогаш немаше да можеме да ја имплементираме нашата идеа. Единствениот проблем е тоа што мора да се користат песни само во .wav формат за да може да работи плеерот. Песните ги чуваме во фолдери во самиот проект, кои што потоа ги поврзуваме со соодветната форма со помош на низи, со тоа што го земаме релативниот пат кон песната.
За нашиот проект користиме една класа која што се вика Song, каде што чуваме само една променлива односно Path што ни го дава патот на една дадена песна. Во оваа класа исто така имаме функција Play која што ќе ја користиме понатаму во функциите кај копчињата Play и Random. Тука едноставно ја повикуваме веќе постоечката функција што се наоѓа во System.Media. 
Во крајните мениа каде што е веќе одбрана музиката што сакаме да ја пуштиме имаме неколку функции. При вчитување на самото мени најпрво ги земаме песните од соодветните фолдери и ги сместуваме во list box кој што се наоѓа на лево. Од таму имаме избор дали сакаме да пуштиме специфична или рандом песна. Исто така повикуваме повикуваме создавање на нов плеер и на класата Random која што ќе ни помогне подоцна во другите функции. 
Следна функција во ова мени е функцијата Play. Тука креираме променлива song од типот Song, и потоа ја повикуваме претходно споменатата функција од класата Song со цел да ја пуштиме селектираната песна, која што ја земаме со ListBox1.SelectedItem. Исто така го запишуваме името на песната која што ја пуштаме во текстуалното поле поставено на долниот дел од менито.
Функцијата Stop е прилично едноставна, односно ја повикуваме директно од самиот namespace. Исто така го пребришуваме текстуалното поле. 
Функцијата Random работи на сличен принцип како функцијата Play, само тука користиме Random за да одбереме рандом индекс од дадената листа, и потоа креираме променлива song која што ја зема песната која што се наоѓа на одредениот рандом индекс кој го чуваме во променливата index. Од таму го користиме истиот принцип на работа како во Play.
Функцијата Back исто така е едноставна, односно само го затвора сегашното мени, и го отвара претходното. Ако е во крајното мени ја запира музиката без разлика како е пуштена.


Проектот е поставен на GitHub меѓутоа имавме мал проблем со истиот. Поради тоа што моравме песните да ги ставиме во самиот проект со цел да работи според нашата оргинална замисла, нашиот проект имаше премногу фајлови за да може да биде commitнат на GitHub. На GitHub е поставена последната верзија без фолдерите со песните, така што нема да биде целосно функционална ако се гледа само таа верзија. Поради големината на проектот изворниот код може да се најде на линкот поставен во документот поставен на code.finki.ukim.mk.
