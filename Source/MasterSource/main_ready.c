#include <16f877a.h>                   
#fuses HS,NOWDT,NOPROTECT,PUT,NOLVP 
#device adc=8                           //  A/D  de 10 bits ou 8 a defenir
#use delay (clock=4000000)                
#include <flex_lcd.c>
#include <stdio.h>
#include <stdlib.h>                      // Necessario para funcao atol ou atoi
#use fast_io(C)
#use fast_io(B)
#use i2c(MASTER, SDA=PIN_C4, SCL=PIN_C3)
#use rs232(baud=9600, parity=N, xmit=PIN_C6, rcv=PIN_C7, bits=8,stream=rs232)

// Defeniçoes de Pinos
#define led_rs_on    output_low(PIN_D0)  // Indicador Actividade Uart
#define led_rs_off  output_high(PIN_D0)

#define led_spp_on  output_low(PIN_D1)  // Indicador Actividade I2c
#define led_spp_off output_high(PIN_D1)

// Defeniçoes De Rom

#define lenbuff 5                   // Comprimento Buffer Rs - Alterar tamanho se necessario


// Variaveis em Ram
int buffer_adc[6]  = {128,128,128,128,128,128};        // Buffer inciados com valor medio       
int buffer_cpu[6]  = {128,128,128,128,128,128};
int buffer_mano[6] = {128,128,128,128,128,128};

char rs_buffer[lenbuff];            // Buffer Uart
char x=0;
char y=0;
char canal;
char index = 0x00;                // Index Buffer
char flag_request =0x00;                  //  Flag control
// Declaracao Funcoes

void inicbuff(void);
void chose_arm();
void ini();
void analog_config();
void serial_isr();
void show_mano();
void show_cpu();
void show_adc();
void select_cpu();
void send_cpu(char cu);

void inicbuff(void)                // Funçao limpar Rs_Buffer
 {
   char i;
   for(i=0;i<6;i++)           
   {
      rs_buffer[i]=0x00;            // Limpo posicoes  
   }
   index=0x00;                      // Inicializo index
   enable_interrupts(int_rda);      // Hablito interrupçao rs
 }



// Interrupcao
#int_rda                            // Funcao lidar com interrupcao
  void serial_isr()                 // para recepcao da Uart
  {
   char c;
   led_rs_on;                       // Indicador actividade da Uart
   if(kbhit())                      // Comprobo se existe bit de "start para a Uart
   {
     c = getc();
     if ( c == '|'){
         rs_buffer[index]= c;          // Puxo caracter para buffer
         disable_interrupts(int_rda);  // Desbilito rda
         chose_arm();                  // Chamo funçao 
         } 
      else if ( index <lenbuff){
         rs_buffer[index++]= c;  
         }
   }
   led_rs_off;                           // fim de actividade
}

void chose_arm(void)
{

   switch (rs_buffer[3])
   {
      case 'a':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[0] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'b':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[1] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'c':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[2] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'd':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[3] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'e':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[4] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'f':
         if (rs_buffer[0]=='s'){
         // stop_arm(buffer_rs[3];
         }
         else{
         buffer_cpu[5] = atoi(rs_buffer);
         inicbuff();
         }
      break;
      case 'j':
         {
      inicbuff();
      flag_request=1;
      }
      break;
      default:
         inicbuff();  
   }        
}




void ini ()
{

   lcd_init(); 
   delay_ms(2);      
   x=1;y=1;
   lcd_gotoxy(x,y);
   printf(lcd_putc,"     Hugo Soares  ");
   x=1;y=2;
   lcd_gotoxy(x,y);
   printf(lcd_putc,"  **  Apresenta  **");
   delay_ms(2000);
   printf(lcd_putc,"\f" ) ;  
   x=1;y=1;
   lcd_gotoxy(x,y);
   printf(lcd_putc,"    Robot Mentor   " ) ;
   x=1;y=2;
   lcd_gotoxy(x,y);
   printf(lcd_putc,"********************" ) ;
   delay_ms(2000);
   lcd_putc("\f");
   x=1;y=1;
   lcd_gotoxy(x,y);

}



void analog_config()          // Porto analogico
{
setup_adc_ports(an0);
setup_adc(ADC_CLOCK_INTERNAL);
set_tris_a(0b00000001);
set_tris_b(0x00); 
set_tris_c (0b10000000);
set_tris_d (0b11111100);
enable_interrupts(global);
enable_interrupts(int_rda);

led_rs_off;
led_spp_off;
}

void set_channel()
{
if (canal==0)
      {
      output_c(0x00);
      }
else if (canal==1)
      {
      output_c(0x01);
      }
else if (canal==2)
      {
      output_c(0x02);
      }
else if (canal==3)
      {
      output_c(0x03);
      }
else if (canal==4)
      {
      output_c(0x04);
      }
else if (canal==5)
      {
      output_c(0x05);
      }
}



void read_valor()
{
set_adc_channel(0);
delay_us(10);
buffer_mano[canal]=read_adc();
delay_us(10);
}


void show_mano()
{
if (canal>2)
   {
   lcd_gotoxy(11,canal-1);
   }
else if(canal<=2)
   {
   lcd_gotoxy(1,canal+2);
   }
delay_ms(20);               //Delay for wait lcd
printf(lcd_putc,"C%d %3u",canal,buffer_mano[canal]);
}


void show_cpu()
{
if (canal>2)
   {
   lcd_gotoxy(11,canal-1);
   }
else if(canal<=2)
   {
   lcd_gotoxy(1,canal+2);
   }
delay_ms(2);               //Delay for wait lcd
printf(lcd_putc,"C%d %3u",canal,buffer_cpu[canal]);
}


void show_adc()
{
if (canal>2)
   {
   lcd_gotoxy(11,canal-1);
   }
else if(canal<=2)
   {
   lcd_gotoxy(1,canal+2);
   }
delay_ms(2);               //Delay for wait lcd
printf(lcd_putc,"C%d %3u",canal,buffer_adc[canal]);
}

void select_cpu()
{
disable_interrupts(int_rda);
for (canal=0;canal<6;canal++)
   {
   
   switch(canal)
      {
         case 0:send_cpu('a');
         break;
         case 1:send_cpu('b');
         break;
         case 2:send_cpu('c');
         break;
         case 3:send_cpu('d');
         break;
         case 4:send_cpu('e');
         break;
         case 5:send_cpu('f');
         break;
         
      }  
   }
enable_interrupts(int_rda);
}

void send_cpu(char cu)
{
printf("%3u%c|",buffer_cpu[canal],cu);

}

void main(void)

{
   long tempo=0;
   analog_config();
   canal=0;
   ini();
   analog_config();
   
   while(true)
   {
      
      if(tempo>3600)
      {
         
         tempo=0;
      }
      tempo++;    
         for (canal=0;canal<6;canal++)
            {
            set_channel();
            read_valor();
            }
         
         if (tempo == 1)
            {
            lcd_putc('\f');
            lcd_putc("   Posicao Manipulo ");
            for (canal=0; canal<6;canal++)
               {
               show_mano();
               }
            }
         if (tempo == 1200)
            {
            lcd_putc('\f');
            lcd_putc("   Posicao CPU  ");
            for (canal=0;canal<6;canal++)
               {
               show_cpu();
               }
            }
         if (tempo ==2400)
            {
            lcd_putc('\f'); 
            lcd_putc("   Posicao Motores ");
            for (canal=0;canal<6;canal++)
               {       
               show_adc();
               }
            }
         if (flag_request ==1)
            {
            select_cpu();
            flag_request=0;
            }
         
       }
  
  
  }
   

