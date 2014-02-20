/*
	Project.c - D&D Dice and Stat Program
	Computer Science - 10am MWF

	Created by Nic Lake between 10/20/06 and 12/8/06.
	Copyright 2006 Nic Lake. All rights reserved.
	Information taken from "Dungeons and Dragons - Dungeon
	Master's Guide" Core Rulebook II v.3.5
	No content enclosed is under the Open Game License.
	To learn more about the Open Gaming License and the d20
	System License, visit www.wizards.com/d20
*/

/* 
	Things to change:
	- Loot table arrays, rather than massive case statements
*/

#include <stdio.h>
#include <stdarg.h>
#include <stdlib.h>
#include <time.h>

/* Prototypes */
void general_instructions( void );
void dice_roller( int x, int y, int *z );
void handle_dice_roller( void );
void handle_stat_roller( void );
void diceReroll( int a[] );
void diceSort( int a[] );
void handle_default( void );
void calc_mod( int x, int *y );
void translate_number( int x, int *y );
void handle_dm_programs( void );
void mass_init_roller( void );
void handle_experience( void );
void treasure_roller( void );
void coin_roller( int x );
void good_roller( int x );
void item_roller( int x );
void alchemical_item( void );
void armor_item( void );
void weapon_item( void );
void gear_item( void );
void mag_armor( int x );
void mag_weapon( int x );
void mag_potion( int x );
void mag_ring( int x );
void mag_rod( int x );
void mag_scroll( int x );
void mag_staff( int x );
void mag_wand( int x );
void mag_wonder( int x );

int main()
{
	srand(time(NULL));
	
	int main_select; /* Selection for which program to use */
	
	while(1) {
		general_instructions(); /* Display general instructions */
		scanf("%d", &main_select); /* Scan in value to select case */
		
		switch (main_select) {
			
			case 1: /* Dice Roller */
				handle_dice_roller(); /* Run the dice roller program */
				break;
				
			case 2: /* Stat Generator */
				handle_stat_roller(); /* Run the stat roller program */
				break;
				
			case 3:
				handle_dm_programs();
				break;
				
			case 0: /* Exit */
				return 0;
				
			default:
				handle_default(); /* Catch anything other than the possible cases */
		} /* End switch */
	} /* End outer while */
} /* End int main() */

/* Program functions */

/* Display program instructions */
void general_instructions( void )
{
	printf("\nPlease select from the following options:\n"
			"1 - Dice Roller\n"
			"2 - Stat Generator\n"
			"3 - Dungeon Master's Programs\n"
			"0 - Exit\n\n"
			"Your selection - ");
}

/* Dice rolling function*/
void dice_roller( int x, int y, int *z ) /* Lowest, highest, where to store */
{
	(*z) = rand() % y + x; /* Store into *z a number between x and a random number mod y */
}

/* General dice roller */
void handle_dice_roller( void )
{
	int dcount, dsize; /* Dice number and size for dice roller */
	int l; /* Generic loop counter */
	int sum = 0; /* Total storage */
	int dice; /* Temp. dice value storage */
	
	/* Ask for dice number and size */
	printf("\nPlease type in the dice that you need to roll (i.e. 3d6, 1d20, etc.).\n");
	/* Capture first number to dcount, second number to dsize */
	scanf("%dd%d", &dcount, &dsize);
	
	for (l = 0; l < dcount; l++) {
		dice_roller( 1, dsize, &dice ); /* Lowest = 1, highest = dsize, store in dice */
		printf("%d ", dice);
		sum = sum + dice; /* Add value of dice to the sum */
	} /* End for */
	printf("= %d", sum);
}

/* Stat roller and info function */
void handle_stat_roller( void )
{
	int stat_select; /* Selections for which program to use */
	int stat[6]; /* Array to store roll stats */
	int l = 0; /* Generic loop counter */
	int dl; /* Dice loop counter */
	int sum = 0; /* Diceroll total */
	int store; /* Diceroll value storage */
	int dicearray[4]; /* Array for dropping a dice */
	/* Point Buy ints */
	int campaign_type; /* getchar to determine how many points available */
	int total_aval; /* Total points available to use */
	int stat_to_mod; /* getchar to determine which stat to modify */
	int get_stat; /* Value to change stat to */
	int str_stat, dex_stat, con_stat, int_stat, wis_stat, cha_stat; /* Original stats */
	int str_mod, dex_mod, con_mod, int_mod, wis_mod, cha_mod; /* The stat modifier */
	int str_cost, dex_cost, con_cost, int_cost, wis_cost, cha_cost; /* Cost of each individual stat. */
	int hold; /* Temp hold for previous stats */
	int points;
	
	while(1) {
		sum = 0; /* Initialize the sum */
		
		printf("\nPlease select from the following options:\n"
			"1 - 4d6, Reroll Ones, Drop Lowest\n"
			"2 - 4d6, Drop Lowest\n"
			"3 - 3d6, Keep All\n"
			"4 - 1d12, Add 6\n"
			"5 - 1d10, Add 8\n"
			"6 - Point Buy Table\n"
			"7 - Stat Bonus Chart\n"
			"0 - Return to the Main Screen\n\n"
			"Your selection - ");
	scanf("%d", &stat_select);
		
		switch( stat_select ) {
			
			case 1: /* 4d6 drop lowest reroll 1's */
				printf("Stats are:\n");			
				for (l = 0; l <= 5; l++) {
					for (dl = 0; dl <= 3; dl++){
						dice_roller( 1, 6, &dicearray[dl] ); /* Lowest = 1, highest = 6, store in dicearray[dl] */
					} /* End inner for */
					diceReroll( dicearray ); /* Reroll all 1's */
					diceSort( dicearray ); /* Sort all dice from highest to lowest and print */
				} /* End outer for */
					break;
				
			case 2: /* 4d6 drop lowest */
				printf("Stats are:\n");			
				for (l = 0; l <= 5; l++) {
					for (dl = 0; dl <= 3; dl++) {
						dice_roller( 1, 6, &dicearray[dl] ); /* Lowest = 1, highest = 6, store in dicearray[dl] */
					} /* End inner for */
					diceSort( dicearray ); /* Sort all dice from highest to lowest and print */
				} /* End outer for */
					break;
			
			case 3: /* 3d6 */
				printf("Stats are:\n");			
				for (l = 0; l <= 5; l++) {
					for (dl = 0; dl <= 2; dl++) {
						dice_roller( 1, 6, &store ); /* Lowest = 1, highest = 6, store in store */
						printf("%d   ", store);
						sum = sum + store; /* Add store to sum */
						store = 0; /* Re-initialize store */
					} /* End inner for */
					printf("=   %d\n", sum);
					sum = 0; /* Re-initialize sum */
				} /* End outer for */
					break;
			
			case 4: /* 1d12 add 6 */
				printf("Stats are:\n");
				for (l = 0; l <= 5; l++) {
					dice_roller( 1+6, 12, &stat[l] ); /* Lowest = 7, highest = 18, store in stat[l] */
					printf("%d\n", stat[l]);
				} /* Repeat 6 times */
					break;
					
			case 5: /* 1d10 add 8 */
				printf("Stats are:\n");
				for (l = 0; l <= 5; l++) {
					dice_roller( 1+8, 10, &stat[l] ); /* Lowest = 9, highest = 18, store in stat[l] */
					printf("%d\n", stat[l]);
				} /* Repeat 6 times */
					break;
					
			case 6: /* Point buy table */

					printf("**Point Buy Stats Generator**\n\n");
					printf("\nWhat type of campaign are you playing? (Consult your DM)\n\n"
							"1 - Low-powered campaign (15 points)\n"
							"2 - Challenging campaign (22 points)\n"
							"3 - Normal campaign (25 points)\n"
							"4 - Tougher campaign (28 points)\n"
							"5 - High-powered campaign (32 points)\n"
							"0 - Back to the Stat Generator menu\n\n"
							"Your selection - ");
					scanf("%d", &campaign_type);

						switch ( campaign_type ) {

							case 1:
								total_aval = 15;
								break;

							case 2:
								total_aval = 22;
								break;

							case 3:
								total_aval = 25;
								break;

							case 4:
								total_aval = 28;
								break;

							case 5:
								total_aval = 32;
								break;

							case 0:
								continue;

						} /* End campaign_type switch */
					
					points = total_aval;
					
					/* Set initial stats */
					str_stat = 8;
					dex_stat = 8;
					con_stat = 8;
					int_stat = 8;
					wis_stat = 8;
					cha_stat = 8;

					str_cost = 0;
					dex_cost = 0;
					con_cost = 0;
					int_cost = 0;
					wis_cost = 0;
					cha_cost = 0;
					
					/* Calculate initial stat mod */
					calc_mod( str_stat, &str_mod );
					calc_mod( dex_stat, &dex_mod );
					calc_mod( con_stat, &con_mod );
					calc_mod( int_stat, &int_mod );
					calc_mod( wis_stat, &wis_mod );
					calc_mod( cha_stat, &cha_mod );

					while(1){

						printf("\n\n\tStat\tScore\tMod\n");
						printf("----------------------------\n");
						printf("1 -\tStr\t%d\t%d\n", str_stat, str_mod);
						printf("2 -\tDex\t%d\t%d\n", dex_stat, dex_mod);
						printf("3 -\tCon\t%d\t%d\n", con_stat, con_mod);
						printf("4 -\tInt\t%d\t%d\n", int_stat, int_mod);
						printf("5 -\tWis\t%d\t%d\n", wis_stat, wis_mod);
						printf("6 -\tCha\t%d\t%d\n", cha_stat, cha_mod);
						printf("\nPoints remaining: %d\n\n", total_aval);
						printf("Enter a number, or 0 to exit. - ");	
						scanf("%d", &stat_to_mod);

						switch ( stat_to_mod ) {

						case 1: /* Modify strength */
							printf("\n\nWhat would you like to change Str to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = str_stat;
							str_stat = get_stat;
							calc_mod( str_stat, &str_mod );
							translate_number( str_stat, &str_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + str_cost;
									str_stat = hold;
								}
							break;

						case 2: /* Modify dexterity */
							printf("\n\nWhat would you like to change Dex to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = dex_stat;
							dex_stat = get_stat;
							calc_mod( dex_stat, &dex_mod );
							translate_number( dex_stat, &dex_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + dex_cost;
									dex_stat = hold;
								}
							break;

						case 3: /* Modify constitution */
							printf("\n\nWhat would you like to change Con to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = con_stat;
							con_stat = get_stat;
							calc_mod( con_stat, &con_mod );
							translate_number( con_stat, &con_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + con_cost;
									con_stat = hold;
								}
							break;

						case 4: /* Modify intelligence */
							printf("\n\nWhat would you like to change Int to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = int_stat;
							int_stat = get_stat;
							calc_mod( int_stat, &int_mod );
							translate_number( int_stat, &int_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + int_cost;
									int_stat = hold;
								}
							break;

						case 5: /* Modify wisdom */
							printf("\n\nWhat would you like to change Wis to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = wis_stat;
							wis_stat = get_stat;
							calc_mod( wis_stat, &wis_mod );
							translate_number( wis_stat, &wis_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + wis_cost;
									wis_stat = hold;
								}
							break;

						case 6: /* Modify charisma */
							printf("\n\nWhat would you like to change Cha to? (between 8 and 20) - ");
							scanf("%d", &get_stat );
							hold = cha_stat;
							cha_stat = get_stat;
							calc_mod( cha_stat, &cha_mod );
							translate_number( cha_stat, &cha_cost );
							total_aval = points-(str_cost+dex_cost+con_cost+int_cost+wis_cost+cha_cost);
								if (total_aval < 0) {
									printf("\n***You don't have enough points to do that!***");
									total_aval = total_aval + cha_cost;
									cha_stat = hold;
								}
								break;

						case 0:
							return;

						} /* End switch */

					} /* End while */

				break;
					
			case 7: /* Stat bonus chart */
				printf("----------------------------\n"
						"|                          |\n"
						"|    -Stat Bonus Chart-    |\n"
						"|                          |\n"
						"|  Score\t   Bonus   |\n"
						"|  1\t\t   -5      |\n"
						"|  2-3\t\t   -4      |\n"
						"|  4-5\t\t   -3      |\n"
						"|  6-7\t\t   -2      |\n"
						"|  8-9\t\t   -1      |\n"
						"|  10-11\t   +0      |\n"
						"|  12-13\t   +1      |\n"
						"|  14-15\t   +2      |\n"
						"|  16-17\t   +3      |\n"
						"|  18-19\t   +4      |\n"
						"|  20-21\t   +5      |\n"
						"|                          |\n"
						"| Formula for stat bonus:  |\n"
						"| (Stat/2) - 5, round down |\n"
						"|                          |\n"
						"----------------------------\n\n");
				break;
						
			case 0: 
				return;
		} /* End switch */
	} /* End while(1) */
} /* End handle_stat_roller function */

/* Reroll 1's */
void diceReroll( int a[] )
{
	int c; /* Comparison counter */
	
	for ( c = 0; c <= 3; ) { /*reroll all 1's*/
		if ( a[c] == 1 ) {
			dice_roller( 1, 6, &a[c] ); /* Lowest = 1, highest = 6, store in a[c] */
		} /* If reroll occured, go back and check it again */
		else c++; /* If no reroll occured, go on to the next dice */
	} /* End for */
}

/* Sort dice from highest to lowest */
void diceSort( int a[] )
{
	int pass; /* Pass counter */
	int j; /* Comparison counter */
	int hold; /* Temp. hold location */
	int total; /* Sum of top 3 in array */
	
	for ( pass = 1; pass < 4; pass++ ) {
		for ( j = 0; j < 3; j++ ) {
			if ( a[j] < a[j + 1] ) { /*swapping so order is greatest to least*/
				hold = a[j]; /* Place value of a[j] into hold */
				a[j] = a[j+1]; /* a[j] becomes what a[j+1] was */
				a[j+1] = hold; /* a[j+1] becomes what a[j] was */
			} /* End if */
		} /* End inner for */
	} /* End outer for */
	
	for (j = 0; j < 3; j++) { /* Print the highest 3 dice rolls */
		printf(" %d, ", a[j]);
	}

	if (j = 3) { /* Print the lowest dice roll */
		printf(" (%d). ", a[j]);
	}
	
	total = a[0] + a[1] + a[2]; /* print the sum of the first 3*/
	printf(" Stat is %d.\n", total);
}

/* Error message */
void handle_default( void )
{
	printf("Incorrect input; please try again.\n\n");
}

/* Calculate stat mod */
void calc_mod( int x, int *y )
{
	*y = x / 2 - 5;
}

/* Translate stat value into stat cost */
void translate_number( int x, int *y )
{
	switch ( x )
	{
		case 8:
			*y = 0;
			break;
			
		case 9:
			*y = 1;
			break;
		
		case 10:
			*y = 2;
			break;
		
		case 11:
			*y = 3;
			break;
		
		case 12:
			*y = 4;
			break;
		
		case 13:
			*y = 5;
			break;
		
		case 14:
			*y = 6;
			break;
		
		case 15:
			*y = 8;
			break;
		
		case 16:
			*y = 10;
			break;
		
		case 17:
			*y = 13;
			break;
		
		case 18:
			*y = 16;
			break;
		
		case 19:
			*y = 20;
			break;
		
		case 20:
			*y = 24;
			break;
	}
}

/* Various programs to assist DM's */
void handle_dm_programs( void )
{
	int op; /* Operation selected */
	
	while(1) {
		
	printf("\nSelect from the folowing options:\n"
			"1 - Mass initiative roller\n"
			"2 - Experience calculator\n"
			"3 - Treasure roller (not yet completed)\n"
			"0 - Return to the Main Menu\n"
			"\nYour selection - ");
	scanf("%d", &op);
	
		switch (op) {
			
			case 1: /* Mass initiative roller */
				mass_init_roller();
				break;
				
			case 2: /* Experience generator */
				handle_experience();
				break;
				
			case 3: /* Treasure roller */
				treasure_roller();
				break;
				
			case 0:
				return;
				
		} /*End op switch */
	} /* End while */
} /* End handle_dm_programs function */

/* Experience calculator */
void handle_experience( void )
{
	int party_size;
	int party_lvl = 0;
	int party_el = 0;
	int member_lvl;
	int l, c; /* Generic loop counters */
	int mob_size;
	int mob_lvl = 0;
	int xp = 0; /* Total experience */
	
	
	while(1) {
		printf("\n\nEnter the party size or 0 to exit - ");
		scanf("%d", &party_size);
		
		if (party_size == 0) return;
		
		printf("\n");
		for (l = 0; l < party_size; l++) {
			printf("Enter the level of member %d - ", l+1);
			scanf("%d", &member_lvl);
			party_lvl = party_lvl + member_lvl;
		} /* End for */
		
		party_el = party_lvl / 4;
		printf("\nThe party is EL %d.", party_el);
		
		printf("\n\nEnter the mob size - ");
		scanf("%d", &mob_size);
		
		printf("\n");
		for (c = 0; c < mob_size; c++) {
			printf("Enter the CR of monster %d - ", c+1);
			scanf("%d", &mob_lvl);
		
		switch(party_el) {
			case 1:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
					
					case 2:
						xp = xp + 600;
						break;

					case 3:
						xp = xp + 900;
						break;

					case 4:
						xp = xp + 1350;
						break;

					case 5:
						xp = xp + 1800;
						break;

					case 6:
						xp = xp + 2700;
						break;

					case 7:
						xp = xp + 3600;
						break;

					case 8:
						xp = xp + 5400;
						break;

					case 9:
						xp = xp + 7200;
						break;
					
					case 10:
						xp = xp + 10800;
						break;
					
						default:
							printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
									"above *or* below your party's CR.  For determining experience for these\n"
									"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
							return;
				}
				break;
					
			case 2:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
					
					case 2:
						xp = xp + 600;
						break;

					case 3:
						xp = xp + 900;
						break;

					case 4:
						xp = xp + 1350;
						break;

					case 5:
						xp = xp + 1800;
						break;

					case 6:
						xp = xp + 2700;
						break;

					case 7:
						xp = xp + 3600;
						break;

					case 8:
						xp = xp + 5400;
						break;

					case 9:
						xp = xp + 7200;
						break;
					
					case 10:
						xp = xp + 10800;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
		
			case 3:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
					
					case 2:
						xp = xp + 600;
						break;

					case 3:
						xp = xp + 900;
						break;

					case 4:
						xp = xp + 1350;
						break;

					case 5:
						xp = xp + 1800;
						break;

					case 6:
						xp = xp + 2700;
						break;

					case 7:
						xp = xp + 3600;
						break;

					case 8:
						xp = xp + 5400;
						break;

					case 9:
						xp = xp + 7200;
						break;
					
					case 10:
						xp = xp + 10800;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
		
			case 4:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
						
					case 2:
						xp = xp + 600;
						break;

					case 3:
						xp = xp + 800;
						break;

					case 4:
						xp = xp + 1200;
						break;

					case 5:
						xp = xp + 1600;
						break;

					case 6:
						xp = xp + 2400;
						break;

					case 7:
						xp = xp + 3200;
						break;

					case 8:
						xp = xp + 4800;
						break;

					case 9:
						xp = xp + 6400;
						break;

					case 10:
						xp = xp + 9600;
						break;

					case 11:
						xp = xp + 12800;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 5:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
					
					case 2:
						xp = xp + 500;
						break;

					case 3:
						xp = xp + 750;
						break;

					case 4:
						xp = xp + 1000;
						break;

					case 5:
						xp = xp + 1500;
						break;

					case 6:
						xp = xp + 2250;
						break;	

					case 7:
						xp = xp + 3000;
						break;

					case 8:
						xp = xp + 4500;
						break;

					case 9:
						xp = xp + 6000;
						break;

					case 10:
						xp = xp + 9000;
						break;

					case 11:
						xp = xp + 12000;
						break;

					case 12:
						xp = xp + 18000;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 6:
				switch(mob_lvl) {
					case 1:
						xp = xp + 300;
						break;
					
					case 2:
						xp = xp + 450;
						break;

					case 3:
						xp = xp + 600;
						break;

					case 4:
						xp = xp + 900;
						break;

					case 5:
						xp = xp + 1200;
						break;

					case 6:
						xp = xp + 1800;
						break;

					case 7:
						xp = xp + 2700;
						break;

					case 8:
						xp = xp + 3600;
						break;

					case 9:
						xp = xp + 5400;
						break;

					case 10:
						xp = xp + 7200;
						break;

					case 11:
						xp = xp + 10800;
						break;

					case 12:
						xp = xp + 14400;
						break;

					case 13:
						xp = xp + 21600;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 7:
				switch(mob_lvl) {
					case 1:
						xp = xp + 263;
						break;
						
					case 2:
						xp = xp + 350;
						break;
						
					case 3:
						xp = xp + 525;
						break;

					case 4:
						xp = xp + 700;
						break;

					case 5:
						xp = xp + 1050;
						break;

					case 6:
						xp = xp + 1400;
						break;

					case 7:
						xp = xp + 2100;
						break;

					case 8:
						xp = xp + 3150;
						break;

					case 9:
						xp = xp + 4200;
						break;

					case 10:
						xp = xp + 6300;
						break;

					case 11:
						xp = xp + 8400;
						break;

					case 12:
						xp = xp + 12600;
						break;

					case 13:
						xp = xp + 16800;
						break;

					case 14:
						xp = xp + 25200;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
				
			case 8:
				switch(mob_lvl) {
					case 1:
						xp = xp + 200;
						break;
						
					case 2:
						xp = xp + 300;
						break;

					case 3:
						xp = xp + 400;
						break;

					case 4:
						xp = xp + 600;
						break;

					case 5:
						xp = xp + 800;
						break;

					case 6:
						xp = xp + 1200;
						break;

					case 7:
						xp = xp + 1600;
						break;

					case 8:
						xp = xp + 2400;
						break;

					case 9:
						xp = xp + 3600;
						break;

					case 10:
						xp = xp + 4800;
						break;

					case 11:
						xp = xp + 7200;
						break;

					case 12:
						xp = xp + 9600;
						break;

					case 13:
						xp = xp + 14400;
						break;

					case 14:
						xp = xp + 19200;
						break;

					case 15:
						xp = xp + 28800;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 9:
				switch(mob_lvl) {
					case 2:
						xp = xp + 225;
						break;

					case 3:
						xp = xp + 338;
						break;

					case 4:
						xp = xp + 450;
						break;

					case 5:
						xp = xp + 675;
						break;

					case 6:
						xp = xp + 900;
						break;

					case 7:
						xp = xp + 1350;
						break;

					case 8:
						xp = xp + 1800;
						break;

					case 9:
						xp = xp + 2700;
						break;

					case 10:
						xp = xp + 4050;
						break;

					case 11:
						xp = xp + 5400;
						break;

					case 12:
						xp = xp + 8100;
						break;

					case 13:
						xp = xp + 10800;
						break;

					case 14:
						xp = xp + 16200;
						break;

					case 15:
						xp = xp + 21600;
						break;

					case 16:
						xp = xp + 32400;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 10:
				switch(mob_lvl) {
					case 3:
						xp = xp + 250;
						break;

					case 4:
						xp = xp + 375;
						break;

					case 5:
						xp = xp + 500;
						break;

					case 6:
						xp = xp + 750;
						break;

					case 7:
						xp = xp + 1000;
						break;

					case 8:
						xp = xp + 1500;
						break;

					case 9:
						xp = xp + 2000;
						break;

					case 10:
						xp = xp + 3000;
						break;

					case 11:
						xp = xp + 4500;
						break;

					case 12:
						xp = xp + 6000;
						break;

					case 13:
						xp = xp + 9000;
						break;

					case 14:
						xp = xp + 12000;
						break;

					case 15:
						xp = xp + 18000;
						break;

					case 16:
						xp = xp + 24000;
						break;

					case 17:
						xp = xp + 36000;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 11:
				switch(mob_lvl) {
					case 4:
						xp = xp + 275;
						break;

					case 5:
						xp = xp + 413;
						break;

					case 6:
						xp = xp + 550;
						break;

					case 7:
						xp = xp + 825;
						break;

					case 8:
						xp = xp + 1100;
						break;

					case 9:
						xp = xp + 1650;
						break;

					case 10:
						xp = xp + 2200;
						break;

					case 11:
						xp = xp + 3300;
						break;

					case 12:
						xp = xp + 4950;
						break;

					case 13:
						xp = xp + 6600;
						break;

					case 14:
						xp = xp + 9900;
						break;

					case 15:
						xp = xp + 13200;
						break;

					case 16:
						xp = xp + 19800;
						break;

					case 17:
						xp = xp + 26400;
						break;

					case 18:
						xp = xp + 39600;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 12:
				switch(mob_lvl) {
					case 5:
						xp = xp + 300;
						break;

					case 6:
						xp = xp + 450;
						break;

					case 7:
						xp = xp + 600;
						break;

					case 8:
						xp = xp + 900;
						break;

					case 9:
						xp = xp + 1200;
						break;

					case 10:
						xp = xp + 1800;
						break;

					case 11:
						xp = xp + 240;
						break;

					case 12:
						xp = xp + 6300;
						break;

					case 13:
						xp = xp + 5400;
						break;

					case 14:
						xp = xp + 7200;
						break;

					case 15:
						xp = xp + 10800;
						break;

					case 16:
						xp = xp + 14400;
						break;

					case 17:
						xp = xp + 21600;
						break;

					case 18:
						xp = xp + 28800;
						break;

					case 19:
						xp = xp + 43200;
						break;

					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 13:
				switch(mob_lvl) {
					case 6:
						xp = xp + 325;
						break;

					case 7:
						xp = xp + 488;
						break;

					case 8:
						xp = xp + 650;
						break;

					case 9:
						xp = xp + 975;
						break;

					case 10:
						xp = xp + 1300;
						break;

					case 11:
						xp = xp + 1950;
						break;

					case 12:
						xp = xp + 2600;
						break;

					case 13:
						xp = xp + 3900;
						break;

					case 14:
						xp = xp + 5850;
						break;

					case 15:
						xp = xp + 7800;
						break;

					case 16:
						xp = xp + 11700;
						break;

					case 17:
						xp = xp + 15600;
						break;

					case 18:
						xp = xp + 23400;
						break;

					case 19:
						xp = xp + 31200;
						break;

					case 20:
						xp = xp + 46800;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 14:
				switch(mob_lvl) {
					case 7:
						xp = xp + 350;
						break;

					case 8:
						xp = xp + 525;
						break;

					case 9:
						xp = xp + 700;
						break;

					case 10:
						xp = xp + 1050;
						break;

					case 11:
						xp = xp + 1400;
						break;

					case 12:
						xp = xp + 2100;
						break;

					case 13:
						xp = xp + 2800;
						break;

					case 14:
						xp = xp + 4200;
						break;

					case 15:
						xp = xp + 6300;
						break;

					case 16:
						xp = xp + 8400;
						break;

					case 17:
						xp = xp + 12600;
						break;

					case 18:
						xp = xp + 16800;
						break;

					case 19:
						xp = xp + 25200;
						break;

					case 20:
						xp = xp + 33600;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 15:
				switch(mob_lvl) {
					case 8:
						xp = xp + 375;
						break;

					case 9:
						xp = xp + 563;
						break;

					case 10:
						xp = xp + 750;
						break;

					case 11:
						xp = xp + 1125;
						break;

					case 12:
						xp = xp + 1500;
						break;

					case 13:
						xp = xp + 2250;
						break;

					case 14:
						xp = xp + 3000;
						break;

					case 15:
						xp = xp + 4500;
						break;

					case 16:
						xp = xp + 6750;
						break;

					case 17:
						xp = xp + 9000;
						break;

					case 18:
						xp = xp + 13500;
						break;

					case 19:
						xp = xp + 18000;
						break;

					case 20:
						xp = xp + 27000;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 16:
				switch(mob_lvl) {
					case 9:
						xp = xp + 400;
						break;

					case 10:
						xp = xp + 600;
						break;

					case 11:
						xp = xp + 800;
						break;

					case 12:
						xp = xp + 1200;
						break;

					case 13:
						xp = xp + 1600;
						break;

					case 14:
						xp = xp + 2400;
						break;

					case 15:
						xp = xp + 3200;
						break;

					case 16:
						xp = xp + 4800;
						break;

					case 17:
						xp = xp + 7200;
						break;

					case 18:
						xp = xp + 9600;
						break;

					case 19:
						xp = xp + 14400;
						break;

					case 20:
						xp = xp + 19200;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 17:
				switch(mob_lvl) {
					case 10:
						xp = xp + 425;
						break;

					case 11:
						xp = xp + 638;
						break;

					case 12:
						xp = xp + 850;
						break;

					case 13:
						xp = xp + 1275;
						break;

					case 14:
						xp = xp + 1700;
						break;

					case 15:
						xp = xp + 2550;
						break;

					case 16:
						xp = xp + 3400;
						break;

					case 17:
						xp = xp + 5100;
						break;

					case 18:
						xp = xp + 7650;
						break;

					case 19:
						xp = xp + 10200;
						break;

					case 20:
						xp = xp + 15300;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 18:
				switch(mob_lvl) {
					case 11:
						xp = xp + 450;
						break;

					case 12:
						xp = xp + 675;
						break;

					case 13:
						xp = xp + 900;
						break;

					case 14:
						xp = xp + 1350;
						break;

					case 15:
						xp = xp + 1800;
						break;

					case 16:
						xp = xp + 2700;
						break;

					case 17:
						xp = xp + 3600;
						break;

					case 18:
						xp = xp + 5400;
						break;

					case 19:
						xp = xp + 8100;
						break;

					case 20:
						xp = xp + 10800;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 19:
				switch(mob_lvl) {
					case 12:
						xp = xp + 475;
						break;

					case 13:
						xp = xp + 713;
						break;

					case 14:
						xp = xp + 950;
						break;

					case 15:
						xp = xp + 1425;
						break;

					case 16:
						xp = xp + 1900;
						break;

					case 17:
						xp = xp + 2850;
						break;

					case 18:
						xp = xp + 3800;
						break;

					case 19:
						xp = xp + 5700;
						break;

					case 20:
						xp = xp + 8550;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
				}
				break;
	
			case 20:
				switch(mob_lvl) {
					case 13:
						xp = xp + 500;
						break;

					case 14:
						xp = xp + 750;
						break;

					case 15:
						xp = xp + 1000;
						break;

					case 16:
						xp = xp + 1500;
						break;

					case 17:
						xp = xp + 2000;
						break;

					case 18:
						xp = xp + 3000;
						break;

					case 19:
						xp = xp + 4000;
						break;

					case 20:
						xp = xp + 6000;
						break;
					
					default:
						printf("\nThis generator doesn't support XP for monsters 8 or more levels\n"
								"above *or* below your party's CR.  For determining experience for these\n"
								"encounters, please see the DM Guide, pg. 39 - 'Assigning Ad Hoc XP Awards'.\n\n");
						return;
					
					
				} /* End level 20 */
				break;
		
			} /* End party_lvl switch */
		
		} /* End for (c) */
		
		printf("\nXP for the whole party is %d.", xp);
		printf("\nXP for each member of the party is %d.\n\n", xp/party_size);
		
		return;
	} /* End while(1) */
}

/* Large mob initiative roller */
void mass_init_roller( void )
{
	int monster_num, monster_init;
	int init;
	int l;
	
	printf("\n\nThe mass initiative roller is intended for use for a mob of similar monsters,\n"
			"like 4 trolls, 6 troglodytes, etc.  Different monsters with different initiative\n"
			"modifiers will have to be calculated seperately.");
	printf("\n\nEnter the number of monsters: ");
	scanf("%d", &monster_num);
	printf("\nEnter the monster's initiative modifier: ");
	scanf("%d", &monster_init);
	
	printf("\n\nThe initiatives of all %d monsters in the mob are:\n", monster_num);
	
	for (l = 0; l < monster_num; l++) {
		dice_roller( 1 + monster_init, 20, &init );
		printf("%d ", init );
	}
	printf("\n\n");
}

/* Treasure roller */
void treasure_roller( void )
{
	int mon_lvl; /* Monster level */
	
	while(1) {
		printf("\n\nRemember to always use your best judgement when\n"
				"giving out treasure to players.  Some monsters\n"
				"have more treasure than others, while others have\n"
				"less, or even none.  This generator does not include\n"
				"intelligent or cursed items; for information on these,\n"
				"see page 214 in the DM Guide.");
		printf("\n\nEnter in the CR of the defeated monster, or 00 to exit - ");
		scanf("%d", &mon_lvl);
		
		if (mon_lvl==00) {
			break;
		}
		
		if (mon_lvl>=21) {
			handle_default();
		}
		
		coin_roller( mon_lvl );
		good_roller( mon_lvl );
		item_roller( mon_lvl );
	} /* End while(1) */
	
}

/* Coin roller */
void coin_roller ( int x )
{
	int coins; /* coins */
	int perc; /* percentage roll */
	int mult; /* multiplier storage for coins */
	
	dice_roller(1, 100, &perc);
	
		switch (x) {
		 	case 1:
				if (perc<=14) {
					printf("No coins.\n");
					break;
				}
				while (perc>=15 && perc<=29) {
					dice_roller(1, 6, &mult);
					coins=mult * 1000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=30 && perc<=52) {
					dice_roller(1, 8, &mult);
					coins=mult * 100;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=53 && perc<=95) {
					dice_roller(2, 16, &mult);
					coins=mult * 10;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 4, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 2:
				if (perc<=13) {
					printf("No coins.\n");
					break;
				}
				while (perc>=14 && perc<=23) {
					dice_roller(1, 10, &mult);
					coins=mult * 1000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=24 && perc<=43) {
					dice_roller(2, 20, &mult);
					coins=mult * 100;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=44 && perc<=95) {
					dice_roller(4, 40, &mult);
					coins=mult * 10;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(2, 16, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 3:
				if (perc<=11) {
					printf("No coins.\n");
					break;
				}
				while (perc>=12 && perc<=21) {
					dice_roller(2, 20, &mult);
					coins=mult * 1000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=22 && perc<=41) {
					dice_roller(4, 32, &mult);
					coins=mult * 100;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=42 && perc<=95) {
					dice_roller(1, 4, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 10, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 4:
				if (perc<=11) {
					printf("No coins.\n");
					break;
				}
				while (perc>=12 && perc<=21) {
					dice_roller(3, 30, &mult);
					coins=mult * 1000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=22 && perc<=41) {
					dice_roller(4, 48, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=53 && perc<=95) {
					dice_roller(2, 16, &mult);
					coins=mult * 10;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 4, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 5:
				if (perc<=10) {
					printf("No coins.\n");
					break;
				}
				while (perc>=11 && perc<=19) {
					dice_roller(1, 4, &mult);
					coins=mult * 10000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=20 && perc<=38) {
					dice_roller(1, 6, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=39 && perc<=95) {
					dice_roller(1, 8, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 10, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 6:
				if (perc<=10) {
					printf("No coins.\n");
					break;
				}
				while (perc>=11 && perc<=18) {
					dice_roller(1, 6, &mult);
					coins=mult * 10000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=19 && perc<=37) {
					dice_roller(1, 8, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=38 && perc<=95) {
					dice_roller(1, 10, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 12, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 7:
				if (perc<=11) {
					printf("No coins.\n");
					break;
				}
				while (perc>=12 && perc<=18) {
					dice_roller(1, 6, &mult);
					coins=mult * 10000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=19 && perc<=37) {
					dice_roller(1, 8, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=38 && perc<=95) {
					dice_roller(1, 10, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 96) {
					dice_roller(1, 12, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 8:
				if (perc<=10) {
					printf("No coins.\n");
					break;
				}
				while (perc>=11 && perc<=15) {
					dice_roller(1, 12, &mult);
					coins=mult * 10000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=16 && perc<=29) {
					dice_roller(2, 12, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=30 && perc<=87) {
					dice_roller(2, 16, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 88) {
					dice_roller(3, 18, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 9:
				if (perc<=10) {
					printf("No coins.\n");
					break;
				}
				while (perc>=11 && perc<=15) {
					dice_roller(2, 12, &mult);
					coins=mult * 10000;
					printf("%d copper coins.\n", coins);
					break;
				}
				while (perc>=16 && perc<=29) {
					dice_roller(2, 16, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=30 && perc<=85) {
					dice_roller(5, 20, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 86) {
					dice_roller(2, 24, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 10:
				if (perc<=10) {
					printf("No coins.\n");
					break;
				}
				while (perc>=11 && perc<=24) {
					dice_roller(2, 20, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=25 && perc<=79) {
					dice_roller(6, 24, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 80) {
					dice_roller(5, 30, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 11:
				if (perc<=8) {
					printf("No coins.\n");
					break;
				}
				while (perc>=9 && perc<=14) {
					dice_roller(3, 30, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=15 && perc<=75) {
					dice_roller(6, 24, &mult);
					coins=mult * 100;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 76) {
					dice_roller(4, 40, &mult);
					coins=mult * 10;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 12:
				if (perc<=8) {
					printf("No coins.\n");
					break;
				}
				while (perc>=9 && perc<=14) {
					dice_roller(3, 36, &mult);
					coins=mult * 1000;
					printf("%d silver coins.\n", coins);
					break;
				}
				while (perc>=15 && perc<=75) {
					dice_roller(1, 4, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 76) {
					dice_roller(1, 4, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 13:
				if (perc<=8) {
					printf("No coins.\n");
					break;
				}
				while (perc>=9 && perc<=75) {
					dice_roller(1, 4, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 76) {
					dice_roller(1, 10, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 14:
				if (perc<=8) {
					printf("No coins.\n");
					break;
				}
				while (perc>=9 && perc<=75) {
					dice_roller(1, 6, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 76) {
					dice_roller(1, 12, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 15:
				if (perc<=3) {
					printf("No coins.\n");
					break;
				}
				while (perc>=4 && perc<=74) {
					dice_roller(1, 8, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 75) {
					dice_roller(3, 12, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 16:
				if (perc<=3) {
					printf("No coins.\n");
					break;
				}
				while (perc>=4 && perc<=74) {
					dice_roller(1, 12, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 75) {
					dice_roller(3, 12, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 17:
				if (perc<=3) {
					printf("No coins.\n");
					break;
				}
				while (perc>=4 && perc<=68) {
					dice_roller(3, 12, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 69) {
					dice_roller(2, 20, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 18:
				if (perc<=2) {
					printf("No coins.\n");
					break;
				}
				while (perc>=3 && perc<=65) {
					dice_roller(3, 18, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 66) {
					dice_roller(5, 20, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 19:
				if (perc<=2) {
					printf("No coins.\n");
					break;
				}
				while (perc>=3 && perc<=65) {
					dice_roller(3, 24, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 66) {
					dice_roller(3, 30, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
			
			case 20:
				if (perc<=2) {
					printf("No coins.\n");
					break;
				}
				while (perc>=3 && perc<=65) {
					dice_roller(4, 32, &mult);
					coins=mult * 1000;
					printf("%d gold coins.\n", coins);
					break;
				}
				if (perc>= 66) {
					dice_roller(4, 40, &mult);
					coins=mult * 100;
					printf("%d platinum coins.\n", coins);
					break;
				}
			break;
		}
}

/* Goods roller */
void good_roller ( int x )
{
	int gem; /* number of gems */
	int art; /* number of art */
	int num;
	int z = 1; /* generic loop counter */
	int value; /* value of good */
	int perc; /* percentage to determine what type is received */
	int tperc; /* percentage to determine specific type of treasure */
	int gem_type, art_type; /* Specific type */
	
	dice_roller(1, 100, &perc);
	
	switch(x) {
		case 1:
			if (perc<=90) {
				
				break;
			}
			while (perc>=91 && perc<=95) {
				gem = 1;
				break;
			}
			if (perc>=96) {
				art = 1;
				break;
			}
		break;
		
		case 2:
			if (perc<=81) {
				
				break;
			}
			while (perc>=82 && perc<=95) {
				dice_roller(1, 3, &gem);
				break;
			}
			if (perc>=96) {
				dice_roller(1, 3, &art);
				break;
			}
		break;
		
		case 3:
			if (perc<=77) {
				
				break;
			}
			while (perc>=78 && perc<=95) {
				dice_roller(1, 3, &gem);
				break;
			}
			if (perc>=96) {
				dice_roller(1, 3, &art);
				break;
			}
		break;
		
		case 4:
			if (perc<=70) {
				
				break;
			}
			while (perc>=71 && perc<=95) {
				dice_roller(1, 4, &gem);
				break;
			}
			if (perc>=96) {
				dice_roller(1, 3, &art);
				break;
			}
		break;
		
		case 5:
			if (perc<=60) {
				
				break;
			}
			while (perc>=61 && perc<=95) {
				dice_roller(1, 4, &gem);
				break;
			}
			if (perc>=96) {
				dice_roller(1, 4, &art);
				break;
			}
		break;
		
		case 6:
			if (perc<=56) {
				
				break;
			}
			while (perc>=57 && perc<=92) {
				dice_roller(1, 4, &gem);
				break;
			}
			if (perc>=93) {
				dice_roller(1, 4, &art);
				break;
			}
		break;
		
		case 7:
			if (perc<=48) {
				
				break;
			}
			while (perc>=49 && perc<=88) {
				dice_roller(1, 4, &gem);
				break;
			}
			if (perc>=89) {
				dice_roller(1, 4, &art);
				break;
			}
		break;
		
		case 8:
			if (perc<=45) {
				
				break;
			}
			while (perc>=46 && perc<=85) {
				dice_roller(1, 6, &gem);
				break;
			}
			if (perc>=86) {
				dice_roller(1, 4, &art);
				break;
			}
		break;
		
		case 9:
			if (perc<=40) {
				
				break;
			}
			while (perc>=41 && perc<=80) {
				dice_roller(1, 8, &gem);
				break;
			}
			if (perc>=81) {
				dice_roller(1, 4, &art);
				break;
			}
		break;
		
		case 10:
			if (perc<=35) {
				
				break;
			}
			while (perc>=36 && perc<=79) {
				dice_roller(1, 8, &gem);
				break;
			}
			if (perc>=80) {
				dice_roller(1, 6, &art);
				break;
			}
		break;
		
		case 11:
			if (perc<=24) {
				
				break;
			}
			while (perc>=25 && perc<=74) {
				dice_roller(1, 10, &gem);
				break;
			}
			if (perc>=75) {
				dice_roller(1, 6, &art);
				break;
			}
		break;
		
		case 12:
			if (perc<=17) {
				
				break;
			}
			while (perc>=18 && perc<=70) {
				dice_roller(1, 10, &gem);
				break;
			}
			if (perc>=71) {
				dice_roller(1, 8, &art);
				break;
			}
		break;
		
		case 13:
			if (perc<=11) {
				
				break;
			}
			while (perc>=12 && perc<=66) {
				dice_roller(1, 12, &gem);
				break;
			}
			if (perc>=67) {
				dice_roller(1, 10, &art);
				break;
			}
		break;
		
		case 14:
			if (perc<=11) {
				
				break;
			}
			while (perc>=12 && perc<=66) {
				dice_roller(2, 16, &gem);
				break;
			}
			if (perc>=67) {
				dice_roller(2, 12, &art);
				break;
			}
		break;
		
		case 15:
			if (perc<=9) {
				
				break;
			}
			while (perc>=10 && perc<=65) {
				dice_roller(2, 20, &gem);
				break;
			}
			if (perc>=66) {
				dice_roller(2, 16, &art);
				break;
			}
		break;
		
		case 16:
			if (perc<=7) {
				
				break;
			}
			while (perc>=8 && perc<=64) {
				dice_roller(4, 24, &gem);
				break;
			}
			if (perc>=65) {
				dice_roller(2, 20, &art);
				break;
			}
		break;
		
		case 17:
			if (perc<=4) {
				
				break;
			}
			while (perc>=5 && perc<=63) {
				dice_roller(4, 32, &gem);
				break;
			}
			if (perc>=64) {
				dice_roller(3, 24, &art);
				break;
			}
		break;
		
		case 18:
			if (perc<=4) {
				
				break;
			}
			while (perc>=5 && perc<=54) {
				dice_roller(3, 36, &gem);
				break;
			}
			if (perc>=55) {
				dice_roller(3, 30, &art);
				break;
			}
		break;
		
		case 19:
			if (perc<=3) {
				
				break;
			}
			while (perc>=4 && perc<=50) {
				dice_roller(6, 36, &gem);
				break;
			}
			if (perc>=51) {
				dice_roller(6, 36, &art);
				break;
			}
		break;
		
		case 20:
			if (perc<=2) {
				
				break;
			}
			while (perc>=4 && perc<=38) {
				dice_roller(4, 40, &gem);
				break;
			}
			if (perc>=39) {
				dice_roller(7, 42, &art);
				break;
			}
		break;
		
		break;
	} /* End switch */

	for (z=1; z<=gem; z++) {
	
		dice_roller(1, 100, &tperc);
	
		if (tperc<=25) {
	
			dice_roller(1, 12, &gem_type);
	
			switch(gem_type) {
				case 1:
					printf("Banded agate - ");
				break;
				
				case 2:
					printf("Eye agate - ");
				break;
				
				case 3:
					printf("Moss agate - ");
				break;
				
				case 4:
					printf("Azurite - ");
				break;
				
				case 5:
					printf("Blue quartz - ");
				break;
				
				case 6:
					printf("Hematite - ");
				break;
				
				case 7:
					printf("Lapis lazuli - ");
				break;
				
				case 8:
					printf("Malachite - ");
				break;
				
				case 9:
					printf("Obsidian - ");
				break;
				
				case 10:
					printf("Rhodochrosite - ");
				break;
				
				case 11:
					printf("Tiger eye turquoise - ");
				break;
				
				case 12:
					printf("Freshwater (irregular) pearl - ");
				break;
			} /* End switch */
			
			dice_roller(4, 16, &value);
			printf("worth %d gold.\n", value);
			break;
			
		} /* End if */
	
		while (tperc>=26 && tperc<= 50) {
		
			dice_roller(1, 17, &gem_type);
			
			switch(gem_type) {
				case 1:
					printf("Bloodstone - ");
				break;

				case 2:
					printf("Carnelian - ");
				break;

				case 3:
					printf("Chalcedony - ");
				break;

				case 4:
					printf("Chrysoprase - ");
				break;

				case 5:
					printf("Citrine - ");
				break;

				case 6:
					printf("Iolite - ");
				break;

				case 7:
					printf("Jasper - ");
				break;

				case 8:
					printf("Moonstone - ");
				break;

				case 9:
					printf("Onyx - ");
				break;

				case 10:
					printf("Peridot - ");
				break;

				case 11:
					printf("Rock crystal (clear quartz) - ");
				break;

				case 12:
					printf("Sard - ");
				break;
				
				case 13:
					printf("Sardonyx - ");
				break;
				
				case 14:
					printf("Rose quartz - ");
				break;
				
				case 15:
					printf("Smoky quartz - ");
				break;
				
				case 16:
					printf("Star rose quartz - ");
				break;
				
				case 17:
					printf("Zircon - ");
				break;
			} /* End switch */
			dice_roller(2, 8, &value);
			printf("worth %d gold.\n", value*10);	
			break;
		} /* End while */
		
		while (tperc>=51 && tperc<= 70) {
		
			dice_roller(1, 16, &gem_type);
			
			switch(gem_type) {
				case 1:
					printf("Amber - ");
				break;

				case 2:
					printf("Amethyst - ");
				break;

				case 3:
					printf("Chrysoberyl - ");
				break;

				case 4:
					printf("Coral - ");
				break;

				case 5:
					printf("Red garnet - ");
				break;

				case 6:
					printf("Brown-green garnet - ");
				break;

				case 7:
					printf("Jade - ");
				break;

				case 8:
					printf("Jet - ");
				break;

				case 9:
					printf("White peral - ");
				break;

				case 10:
					printf("Golden peral - ");
				break;

				case 11:
					printf("Pink peral - ");
				break;

				case 12:
					printf("Silver peral - ");
				break;
				
				case 13:
					printf("Red spinel - ");
				break;
				
				case 14:
					printf("Red-brown spinel - ");
				break;
				
				case 15:
					printf("Deep green spinel - ");
				break;
				
				case 16:
					printf("Tourmaline - ");
				break;
				
			} /* End switch */
			
			dice_roller(4, 16, &value);
			printf("worth %d gold.\n", value*10);	
			break;
		} /* End while */
		
		while (tperc>=71 && tperc<= 90) {
		
			dice_roller(1, 6, &gem_type);
			
			switch(gem_type) {
				case 1:
					printf("Alexandrite - ");
				break;

				case 2:
					printf("Aquamarine - ");
				break;

				case 3:
					printf("Violet garnet - ");
				break;

				case 4:
					printf("Black peral - ");
				break;

				case 5:
					printf("Deep blue spinel - ");
				break;

				case 6:
					printf("Golden yellow topaz - ");
				break;
				
			} /* End switch */
			dice_roller(2, 8, &value);
			printf("worth %d gold.\n", value*100);	
			break;
		} /* End while */
		
		while (tperc>=91 && tperc<= 99) {
		
			dice_roller(1, 10, &gem_type);
			
			switch(gem_type) {
				case 1:
					printf("Emerald - ");
				break;

				case 2:
					printf("White opal - ");
				break;

				case 3:
					printf("Black opal - ");
				break;

				case 4:
					printf("Fire opal - ");
				break;

				case 5:
					printf("Blue sapphire - ");
				break;

				case 6:
					printf("Firey yellow corundum - ");
				break;

				case 7:
					printf("Rich purple corundum - ");
				break;

				case 8:
					printf("Blue star sapphire - ");
				break;

				case 9:
					printf("Black star sapphire - ");
				break;

				case 10:
					printf("Star ruby - ");
				break;
				
			} /* End switch */
			dice_roller(4, 16, &value);
			printf("worth %d gold.\n", value*100);	
			break;
		} /* End while */
		
		if (tperc==100) {
			
			dice_roller(1, 7, &gem_type);
			
			switch(gem_type) {
				case 1:
					printf("Clearest bright green emerald - ");
				break;

				case 2:
					printf("ABlue-white diamond - ");
				break;

				case 3:
					printf("Canary diamond - ");
				break;

				case 4:
					printf("Pink diamond - ");
				break;

				case 5:
					printf("Brown diamond - ");
				break;

				case 6:
					printf("Blue diamond - ");
				break;

				case 7:
					printf("Jacinth - ");
				break;
				
			} /* End switch */
			dice_roller(2, 8, &value);
			printf("worth %d gold.\n", value*1000);	
			break;
		} /* End while */
	} /* End for */

	for (z=1; z<=art; z++) {
	
		dice_roller(1, 100, &tperc);
	
		if (tperc<=10) {
		
			dice_roller(1, 4, &art_type);
		
			switch(art_type) {
				case 1:
					printf("Silver ewer - ");
				break;
				
				case 2:
					printf("Carved bone statuette - ");
				break;
				
				case 3:
					printf("Carved ivory statuette - ");
				break;
				
				case 4:
					printf("Finely wrought small gold bracelet - ");
				break;
			} /* End Switch */
			
			dice_roller(1, 10, &value);
			printf("worth %d gold.\n", value*10);
			break;
			
		} /* End if */
		
		while (tperc>=11 && tperc<=25) {
		
			dice_roller(1, 3, &art_type);
		
			switch(art_type) {
				case 1:
					printf("Cloth of gold vestments - ");
				break;
				
				case 2:
					printf("Black velvet mask with numerous citrines - ");
				break;
				
				case 3:
					printf("Silver chalice with lapis lazuli gems - ");
				break;
				
			} /* End Switch */
			
			dice_roller(3, 18, &value);
			printf("worth %d gold.\n", value*10);
			break;
			
		} /* End while */
	
		while (tperc>=26 && tperc<=40) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Large well-done woll tapestry - ");
				break;
			
				case 2:
					printf("Brass mug with jade inlays - ");
				break;
			} /* End Switch */
		
			dice_roller(1, 6, &value);
			printf("worth %d gold.\n", value*100);
			break;
		
		} /* End while */
	
		while (tperc>=41 && tperc<=50) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Silver comb with moonstones - ");
				break;
			
				case 2:
					printf("Silver-plated steel longsword with jet jewel in hilt - ");
				break;
			} /* End Switch */
		
			dice_roller(1, 10, &value);
			printf("worth %d gold.\n", value*100);
			break;
		
		} /* End while */
	
		while (tperc>=51 && tperc<=60) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Carved harp of exotic wood with ivory inlay and zircon gems - ");
				break;
			
				case 2:
					printf("Solid gold idol (10lbs) - ");
					break;
				}
			} /* End Switch */
		
			dice_roller(2, 12, &value);
			printf("worth %d gold.\n", value*100);
			break;
		
		} /* End wheie */
	
		while (tperc>=61 && tperc<=70) {
	
			dice_roller(1, 3, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Gold dragon comp with red garnet eye - ");
				break;
			
				case 2:
					printf("Gold and topaz bottle stopper cork - ");
				break;
			
				case 3:
					printf("Ceremonial electrum dagger with a start rub in the pommel - ");
				break;
			} /* End Switch */
		
			dice_roller(4, 24, &value);
			printf("worth %d gold.\n", value*100);
			break;
		
		} /* End while */
	
		while (tperc>=71 && tperc<=80) {
	
			dice_roller(1, 3, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Eyepatch with mock eye of sapphire and moonstone - ");
				break;
			
				case 2:
					printf("Fire opal pendant on a fine gold chain - ");
				break;
			
				case 3:
					printf("Old masterpiece painting - ");
				break;
			} /* End Switch */
		
			dice_roller(1, 10, &value);
			printf("worth %d gold.\n", value*10);
			break;
		
		} /* End while */
	
		while (tperc>=81 && tperc<=85) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Embroidered silk and velvet mantle with numerous moonstones - ");
				break;
			
				case 2:
					printf("Sapphire pendant on gold chain - ");
				break;
			} /* End Switch */
		
			dice_roller(5, 30, &value);
			printf("worth %d gold.\n", value*100);
			break;
		
		} /* End while */
	
		while (tperc>=86 && tperc<=90) {
	
			dice_roller(1, 3, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Embroidered and bejeweled glove - ");
				break;
			
				case 2:
					printf("Jeweled anklet - ");
				break;
			
				case 3:
					printf("Gold music box - ");
				break;
			} /* End Switch */
		
			dice_roller(1, 4, &value);
			printf("worth %d gold.\n", value*1000);
			break;
		
		} /* End while */
	
		while (tperc>=91 && tperc<=95) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type)  {
				case 1:
					printf("Golden circlet with four aquamarines - ");
				break;
			
				case 2:
					printf("A string of small pink pearls (necklace) - ");
				break;
			} /* End Switch */
		
			dice_roller(1, 6, &value);
			printf("worth %d gold.\n", value*1000);
			break;
		
		} /* End while */
	
		while (tperc>=96 && tperc<=99)  {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Jeweled gold crown - ");
				break;
			
				case 2:
					printf("Jeweled electrum ring - ");
				break;
			} /* End Switch */
		
			dice_roller(2, 8, &value);
			printf("worth %d gold.\n", value*1000);
			break;
		
		} /* End while */
	
		if (tperc==100) {
	
			dice_roller(1, 2, &art_type);
	
			switch(art_type) {
				case 1:
					printf("Gold and ruby ring - ");
				break;
			
				case 2:
					printf("Gold cup set with emeralds - ");
				break;
			} /* End Switch */
		
			dice_roller(2, 12, &value);
			printf("worth %d gold.\n", value*1000);
		
		} /* End if */
	} /* End for (z=1...) */
}

/* Items roller */
void item_roller ( int x )
{
	int mun = 0;
	int min = 0;
	int med = 0;
	int maj = 0;
	int tperc = 0;
	int perc = 0;
	int z; /* generic loop */
	
	dice_roller(1, 100, &perc);
	
	switch(x) {
		case 1:
			if (perc<=71) {
				break;
			}
			while (perc>=72 && perc<=95) {
				mun=1;
				break;
			}
			if (perc>=96) {
				min=1;
			}
		break;
		
		case 2:
			if (perc<=49) {
				break;
			}
			while (perc>=50 && perc<=85) {
				mun=1;
				break;
			}
			if (perc>=86) {
				min=1;
			}
		break;
		
		case 3:
			if (perc<=49) {
				break;
			}
			while (perc>=50 && perc<=79) {
				dice_roller(1, 3, &mun);
				break;
			}
			if (perc>=80) {
				min=1;
			}
		break;
		
		case 4:
			if (perc<=42) {
				break;
			}
			while (perc>=43 && perc<=62) {
				dice_roller(1, 4, &mun);
				break;
			}
			if (perc>=63) {
				min=1;
			}
		break;
		
		case 5:
			if (perc<=57) {
				break;
			}
			while (perc>=58 && perc<=67) {
				dice_roller(1, 4, &mun);
				break;
			}
			if (perc>=68) {
				dice_roller(1, 3, &min);
			}
		break;
		
		case 6:
			if (perc<=54) {
				break;
			}
			while (perc>=55 && perc<=59) {
				dice_roller(1, 4, &mun);
			}
			while (perc>=60 && perc<=99) {
				dice_roller(1, 3, &min);
				break;
			}
			if (perc==100) {
				med=1;
			}
		break;
		
		case 7:
			if (perc<=51) {
				break;
			}
			while (perc>=52 && perc<=97) {
				dice_roller(1, 3, &min);
				break;
			}
			if (perc>=98) {
				med=1;
			}
		break;
		
		case 8:
			if (perc<=48) {
				break;
			}
			while (perc>=49 && perc<=96) {
				dice_roller(1, 4, &min);
				break;
			}
			if (perc>=97) {
				med=1;
			}
		break;
		
		case 9:
			if (perc<=51) {
				break;
			}
			while (perc>=52 && perc<=91) {
				dice_roller(1, 4, &min);
				break;
			}
			if (perc>=98) {
				med=1;
			}
		break;
		
		case 10:
			if (perc<=40) {
				break;
			}
			while (perc>=41 && perc<=88) {
				dice_roller(1, 4, &min);
				break;
			}
			while (perc>=89 && perc<=99) {
				med=1;
				break;
			}
			if (perc==100) {
				maj=1;
			}
		break;
		
		case 11:
			if (perc<=31) {
				break;
			}
			while (perc>=32 && perc<=84) {
				dice_roller(1, 4, &min);
				break;
			}
			while (perc>=85 && perc<=98) {
				med=1;
				break;
			}
			if (perc>=99) {
				maj=1;
			}
		break;
		
		case 12:
			if (perc<=27) {
				break;
			}
			while (perc>=28 && perc<=82) {
				dice_roller(1, 6, &min);
				break;
			}
			while (perc>=83 && perc<=97) {
				med=1;
				break;
			}
			if (perc>=98) {
				maj=1;
			}
		break;
		
		case 13:
			if (perc<=19) {
				break;
			}
			while (perc>=20 && perc<=73) {
				dice_roller(1, 6, &min);
				break;
			}
			while (perc>=74 && perc<=95) {
				med=1;
				break;
			}
			if (perc>=96) {
				maj=1;
			}
		break;
		
		case 14:
			if (perc<=19) {
				break;
			}
			while (perc>=20 && perc<=58) {
				dice_roller(1, 6, &min);
				break;
			}
			while (perc>=59 && perc<=92) {
				med=1;
				break;
			}
			if (perc>=93) {
				maj=1;
			}
		break;
		
		case 15:
			if (perc<=11) {
				break;
			}
			while (perc>=12 && perc<=46) {
				dice_roller(1, 10, &min);
				break;
			}
			while (perc>=47 && perc<=90) {
				med=1;
				break;
			}
			if (perc>=91) {
				maj=1;
			}
		break;
		
		case 16:
			if (perc<=40) {
				break;
			}
			while (perc>=41 && perc<=46) {
				dice_roller(1, 10, &min);
				break;
			}
			while (perc>=47 && perc<=90) {
				dice_roller(1, 3, &med);
				break;
			}
			if (perc>=91) {
				maj=1;
			}
		break;
		
		case 17:
			if (perc<=33) {
				break;
			}
			while (perc>=34 && perc<=83) {
				dice_roller(1, 3, &med);
				break;
			}
			if (perc>=84) {
				maj=1;
			}
		break;
		
		case 18:
			if (perc<=24) {
				break;
			}
			while (perc>=25 && perc<=80) {
				dice_roller(1, 4, &med);
				break;
			}
			if (perc>=81) {
				maj=1;
			}
		break;
		
		case 19:
			if (perc<=4) {
				break;
			}
			while (perc>=5 && perc<=70) {
				dice_roller(1, 4, &med);
				break;
			}
			if (perc>=71) {
				maj=1;
			}
		break;
		
		case 20:
			if (perc<=25) {
				break;
			}
			while (perc>=26 && perc<=65) {
				dice_roller(1, 4, &med);
				break;
			}
			if (perc>=66) {
				dice_roller(1, 3, &maj);
			}
		break;
	} /* End switch */
	
	if (mun>0) {
		for (z=0; z<mun; z++) {
			dice_roller(1, 100, &tperc);
			
			if (tperc<=17) {
				alchemical_item();
				break;
			}
			while (tperc>=18 && tperc<=50) {
				armor_item();
				break;
			}
			while (tperc>=51 && tperc<=83) {
				weapon_item();
				break;
			}
			if (tperc>=84) {
				gear_item();
			}
		}
	} /* End for loop */
	
	if (min>0) {
		for (z=0; z<min; z++) {
			dice_roller(1, 100, &tperc);
			
			if (tperc<=4) {
				mag_armor(1);
				break;
			}
			while (tperc>=5 && tperc<=9) {
				mag_weapon(1);
				break;
			}
			while (tperc>=10 && tperc<= 44) {
				mag_potion(1);
				break;
			}
			while (tperc>=45 && tperc<=46) {
				mag_ring(1);
				break;
			}
			while (tperc>=47 && tperc<=81) {
				mag_scroll(1);
				break;
			}
			while (tperc>=82 && tperc<=91) {
				mag_wand(1);
				break;
			}
			if (tperc>=92) {
				mag_wonder(1);
			}
		}
	} /* End for loop */
	
	if (med>0) {
		for (z=0; z<med; z++) {
			dice_roller(1, 100, &tperc);
			
			if (tperc<=10) {
				mag_armor(2);
				break;
			}
			while (tperc>=11 && tperc<=20) {
				mag_weapon(2);
				break;
			}
			while (tperc>=21 && tperc<= 30) {
				mag_potion(2);
				break;
			}
			while (tperc>=31 && tperc<=40) {
				mag_ring(2);
				break;
			}
			while (tperc>=41 && tperc<=50) {
				mag_rod(2);
				break;
			}
			while (tperc>=51 && tperc<=65) {
				mag_scroll(2);
				break;
			}
			while (tperc>=66 && tperc<=68) {
				mag_staff(2);
				break;
			}
			while (tperc>=69 && tperc<=83) {
				mag_wand(2);
				break;
			}
			if (tperc>=84) {
				mag_wonder(2);
			}
		} /* End for loop */
	}
	
	if (maj>0) {
		for (z=0; z<maj; z++) {
			dice_roller(1, 100, &tperc);
			
			if (tperc<=10) {
				mag_armor(3);
				break;
			}
			while (tperc>=11 && tperc<=20) {
				mag_weapon(3);
				break;
			}
			while (tperc>=21 && tperc<= 25) {
				mag_potion(3);
				break;
			}
			while (tperc>=26 && tperc<=35) {
				mag_ring(3);
				break;
			}
			while (tperc>=36 && tperc<=45) {
				mag_rod(3);
				break;
			}
			while (tperc>=46 && tperc<=55) {
				mag_scroll(3);
				break;
			}
			while (tperc>=56 && tperc<=75) {
				mag_staff(3);
				break;
			}
			while (tperc>=76 && tperc<=80) {
				mag_wand(3);
				break;
			}
			if (tperc>=81) {
				mag_wonder(3);
			}
		} /* End for loop */
	}
}

/* Alchemical item roller */
void alchemical_item( void )
{
	int item;
	int amount;
	
	dice_roller(1, 100, &item);
	
	if (item<=12) {
		dice_roller(1, 4, &amount);
		printf("%d flask(s) of Alchemist's fire\n", amount);
	}
	while (item>=13 && item<=24) {
		dice_roller(2, 8, &amount);
		printf("%d flask(s) of acid\n", amount);
		break;
	}
	while (item>=25 && item<=36) {
		dice_roller(1, 4, &amount);
		printf("%d smokestick(s)\n", amount);
		break;
	}
	while (item>=37 && item<=48) {
		dice_roller(1, 4, &amount);
		printf("%d flask(s) of holy water\n");
		break;
	}
	while (item>=49 && item<= 62) {
		dice_roller(1, 4, &amount);
		printf("%d dose(s) of antitoxin\n", amount);
		break;
	}
	while (item>=63 && item<=74) {
		printf("1 everburning torch\n");
		break;
	}
	while (item>=75 && item<=88) {
		dice_roller(1, 4, &amount);
		printf("%d tanglefoot bag(s)\n", amount);
		break;
	}
	if (item>=89) {
		dice_roller(1, 4, &amount);
		printf("%d thunderstone(s)\n", amount);
	}
}

/* Armor item roller */
void armor_item( void )
{
	int size;
	int item;
	int spe_item;
	
	dice_roller(1, 100, &size);
	if (size<=10) {
		printf("Small ");
	}
	if (size>=11) {
		printf("Medium ");
	}
	
	dice_roller(1, 100, &item);
	if (item<=12) {
		printf("chain shirt\n");
	}
	while (item>=13 && item<=18) {
		printf("masterwork studded leather\n");
		break;
	}
	while (item<=19 && item<=26) {
		printf("breastplate\n");
		break;
	}
	while (item>=27 && item<=34) {
		printf("banded mail\n");
		break;
	}
	while (item>=35 && item<=54) {
		printf("half-plate\n");
		break;
	}
	while (item>=55 && item<=80) {
		printf("full plate\n");
		break;
	}
	while (item>=81 && item<=90) {
		dice_roller(1, 100, &spe_item);
		if (spe_item<=50) {
			printf("darkwood buckler\n");
		}
		if (spe_item>=51) {
			printf("darkwood shield\n");
		}	
		break;
	}
	if (item>=91) {
		dice_roller(1, 100, &spe_item);
		if (spe_item<=17) {
			printf("masterwork buckler\n");
		}
		while (spe_item>=18 && spe_item<=40) {
			printf("masterwork light wooden shield\n");
			break;
		}
		while (spe_item>=41 && spe_item<=60) {
			printf("masterwork light steel shield\n");
			break;
		}
		while (spe_item>=61 && spe_item<=83) {
			printf("masterwork heavy wooden shield\n");
			break;
		}
		if (spe_item>=84) {
			printf("masterwork heavy steel shield\n");
		}
	}	
}

/* Weapon item roller */
void weapon_item( void )
{
	int perc;
	int wperc;
	int waperc;
	
	printf("Masterwork ");
	
	dice_roller(1, 100, &perc);
	
	if (perc<=50) { /* common weapons */
		dice_roller(1, 100, &wperc);
		
		if (wperc<=4) {
			printf("dagger\n");
		}
		while (wperc>=5 && wperc<=14) {
			printf("greataxe\n");
			break;
		}
		while (wperc>=15 && wperc<=24) {
			printf("greatsword\n");
			break;
		}
		while (wperc>=25 && wperc<=28) {
			printf("kama\n");
			break;
		}
		while (wperc>=29 && wperc<=41) {
			printf("longsword\n");
			break;
		}
		while (wperc>=42 && wperc<=45) {
			printf("light mace\n");
			break;
		}
		while (wperc>=46 && wperc<=50) {
			printf("heavy mace\n");
			break;
		}
		while (wperc>=51 && wperc<=54) {
			printf("nunchaku\n");
			break;
		}
		while (wperc>=55 && wperc<=57) {
			printf("quarterstaff\n");
			break;
		}
		while (wperc>=58 && wperc<=61) {
			printf("rapier\n");
			break;
		}
		while (wperc>=62 && wperc<=66) {
			printf("scimitar\n");
			break;
		}
		while (wperc>=67 && wperc<=70) {
			printf("shortspear\n");
			break;
		}
		while (wperc>=71 && wperc<=74) {
			printf("siangham\n");
			break;
		}
		while (wperc>=75 && wperc<=84) {
			printf("bastard sword\n");
			break;
		}
		while (wperc>=85 && wperc<=89) {
			printf("short sword\n");
			break;
		}
		while (wperc>=90 && wperc<=100) {
			printf("dwarven waraxe\n");
			break;
		}
		
	}
	
	while (perc>=51 && perc<=70) { /* uncommon weapons */
		dice_roller(1, 100, &wperc);
		
		if (wperc<=3) {
			printf("orc double axe\n");
		}
		while (wperc>=4 && wperc<=7) {
			printf("dwarven waraxe\n");
			break;
		}
		while (wperc>=8 && wperc<=10) {
			printf("spiked chain\n");
			break;
		}
		while (wperc>=11 && wperc<=12) {
			printf("club\n");
			break;
		}
		while (wperc>=13 && wperc<=16) {
			printf("hand crossbow\n");
			break;
		}
		while (wperc>=17 && wperc<=19) {
			printf("repeating crossbow\n");
			break;
		}
		while (wperc>=20 && wperc<=21) {
			printf("punching dagger\n");
			break;
		}
		while (wperc>=22 && wperc<=23) {
			printf("falchion\n");
			break;
		}
		while (wperc>=24 && wperc<=26) {
			printf("dire flail\n");
			break;
		}
		while (wperc>=27 && wperc<=31) {
			printf("heavy flail\n");
			break;
		}
		while (wperc>=32 && wperc<=35) {
			printf("light flail\n");
			break;
		}
		while (wperc>=36 && wperc<=37) {
			printf("gauntlet\n");
			break;
		}
		while (wperc>=38 && wperc<=39) {
			printf("spiked gauntlet\n");
			break;
		}
		while (wperc>=40 && wperc<=41) {
			printf("glaive\n");
			break;
		}
		while (wperc>=42 && wperc<=43) {
			printf("greatclub\n");
			break;
		}
		while (wperc>=44 && wperc<=45) {
			printf("guisarme\n");
			break;
		}
		while (wperc>=46 && wperc<=48) {
			printf("halberd\n");
			break;
		}
		while (wperc>=49 && wperc<=51) {
			printf("halfspear\n");
			break;
		}
		while (wperc>=52 && wperc<=54) {
			printf("halfspear\n");
			break;
		}
		while (wperc>=55 && wperc<=56) {
			printf("light hammer\n");
			break;
		}
		while (wperc>=57 && wperc<=58) {
			printf("handaxe\n");
			break;
		}
		while (wperc>=59 && wperc<=61) {
			printf("kukri\n");
			break;
		}
		while (wperc>=62 && wperc<=64) {
			printf("lance\n");
			break;
		}
		while (wperc>=65 && wperc<=67) {
			printf("longspear\n");
			break;
		}
		while (wperc>=68 && wperc<=70) {
			printf("morningstar\n");
			break;
		}
		while (wperc>=71 && wperc<=72) {
			printf("net\n");
			break;
		}
		while (wperc>=73 && wperc<=74) {
			printf("heavy pick\n");
			break;
		}
		while (wperc>=75 && wperc<=76) {
			printf("light pick\n");
			break;
		}
		while (wperc>=77 && wperc<=78) {
			printf("ranseur\n");
			break;
		}
		while (wperc>=79 && wperc<=80) {
			printf("sap\n");
			break;
		}
		while (wperc>=81 && wperc<=82) {
			printf("scythe\n");
			break;
		}
		while (wperc>=83 && wperc<=84) {
			printf("shuriken\n");
			break;
		}
		while (wperc>=85 && wperc<=86) {
			printf("sickle\n");
			break;
		}
		while (wperc>=87 && wperc<=89) {
			printf("two-bladed sword\n");
			break;
		}
		while (wperc>=90 && wperc<=91) {
			printf("trident\n");
			break;
		}
		while (wperc>=92 && wperc<=94) {
			printf("dwarven urgrosh\n");
			break;
		}
		while (wperc>=95 && wperc<=97) {
			printf("warhammer\n");
			break;
		}
		if (wperc>=98) {
			printf("whip\n");
		}
		
		break;
	} /* end while */
	
	if (perc>=71) { /* ranged weapons */
		
		dice_roller(1, 100, &wperc);
		
		if (wperc<=10) {
			dice_roller(1, 100, &waperc);
			if (waperc<=50) {
				printf("50 arrows\n");
			}
			while (waperc>=51 && waperc<=80) {
				printf("50 crossbow bolts\n");
				break;
			}
			if (waperc>=81) {
				printf("50 sling bullets");
			}
		}
		while (wperc>=11 && wperc<=15) {
			printf("throwing axe\n");
			break;
		}
		while (wperc>=16 && wperc<=25) {
			printf("heavy crossbow\n");
			break;
		}
		while (wperc>=26 && wperc<=35) {
			printf("light crossbow\n");
			break;
		}
		while (wperc>=36 && wperc<=39) {
			printf("dart\n");
			break;
		}
		while (wperc>=40 && wperc<=41) {
			printf("javelin\n");
			break;
		}
		while (wperc>=42 && wperc<=46) {
			printf("shortbow\n");
			break;
		}
		while (wperc>=47 && wperc<=51) {
			printf("composite shortbow (+0 Str bonus)\n");
			break;
		}
		while (wperc>=52 && wperc<=56) {
			printf("composite shortbow (+1 Str bonus)\n");
			break;
		}
		while (wperc>=57 && wperc<=61) {
			printf("composite shortbow (+2 Str bonus)\n");
			break;
		}
		while (wperc>=62 && wperc<=65) {
			printf("sling\n");
			break;
		}
		while (wperc>=66 && wperc<=75) {
			printf("longbow\n");
			break;
		}
		while (wperc>=76 && wperc<=80) {
			printf("composite longbow (+0 Str bonus)\n");
			break;
		}
		while (wperc>=81 && wperc<=85) {
			printf("composite longbow (+1 Str bonus)\n");
			break;
		}
		while (wperc>=86 && wperc<=90) {
			printf("composite longbow (+2 Str bonus)\n");
			break;
		}
		while (wperc>=91 && wperc<=95) {
			printf("composite longbow (+3 Str bonus)\n");
			break;
		}
		if (wperc>=96) {
			printf("composite longbow (+4 Str bonus)\n");
		}
	}
}

/* Gear item roller */
void gear_item( void )
{
	int perc;
	
	dice_roller(1, 100, &perc);
	
	if (perc<=3) {
		printf("Empty backpack\n");
	}
	while (perc>=4 && perc<=6) {
		printf("Crowbar\n");
		break;
	}
	while (perc>=7 && perc<=11) {
		printf("Bullseye lantern\n");
		break;
	}
	while (perc>=12 && perc<=16) {
		printf("Simple lock\n");
		break;
	}
	while (perc>=17 && perc<=21) {
		printf("Average lock\n");
		break;
	}
	while (perc>=22 && perc<=28) {
		printf("Good lock\n");
		break;
	}
	while (perc>=29 && perc<=35) {
		printf("Superior lock\n");
		break;
	}
	while (perc>=36 && perc<=40) {
		printf("Masterwork manacles\n");
		break;
	}
	while (perc>=41 && perc<=43) {
		printf("Small steel mirror\n");
		break;
	}
	while (perc>=44 && perc<=46) {
		printf("Silk rope (50 ft.)\n");
		break;
	}
	while (perc>=47 && perc<=53) {
		printf("Spyglass\n");
		break;
	}
	while (perc>=54 && perc<=58) {
		printf("Masterwork artisan's tools\n");
		break;
	}
	while (perc>=59 && perc<=63) {
		printf("Climber's kit\n");
		break;
	}
	while (perc>=64 && perc<=68) {
		printf("Disguise kit\n");
		break;
	}
	while (perc>=69 && perc<=73) {
		printf("Healer's kit\n");
		break;
	}
	while (perc>=74 && perc<=77) {
		printf("Silver holy symbol\n");
		break;
	}
	while (perc>=78 && perc<=81) {
		printf("Hourglass\n");
		break;
	}
	while (perc>=82 && perc<=88) {
		printf("Magnifying glass\n");
		break;
	}
	while (perc>=89 && perc<=95) {
		printf("Masterwork musical instrument\n");
		break;
	}
	if (perc>=96) {
		printf("Masterwork thieves' tools");
	}
}

/* Magic armor roller */
void mag_armor( int x )
{
	int perc;
	int bonus;
	int type;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			if (perc<=60) {
				bonus=1;
				type=1;
			}
			while (perc>=61 && perc<=80) {
				bonus=1;
				type=2;
			}
			while (perc>=81 && perc<=85) {
				bonus=2;
				type=2
			}
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic weapon roller */
void mag_weapon( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Potion roller */
void mag_potion( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			if (perc<=10) {
				printf("Cure light wounds (potion)\n");
				break;
			}
			while (perc>=11 && perc<=13) {
				printf("Endure elements (potion)\n");
				break;
			}
			while (perc>=14 && perc<=15) {
				printf("Hide from animals (potion)\n");
				break;
			}
			while (perc>=16 && perc<=17) {
				printf("Hide from undead (potion)\n");
				break;
			}
			while (perc>=18 && perc<=19) {
				printf("Jump (potion)\n");
				break;
			}
			while (perc>=20 && perc<=22) {
				printf("Mage armor (potion)\n")
				break;
			}
			while (perc>=23 && perc<=25) {
				printf("Magic fang (potion)\n");
				break;
			}
			if (perc==26) {
				printf("Magic stone (oil)\n");
				break;
			}
			while (perc>=27 && perc<=29) {
				printf("Magic weapon (oil)\n");
				break;
			}
			if (perc==30) {
				printf("Pass without trace (potion)\n");
				break;
			}
			while (perc>=31 && perc<=32) {
				printf("Protection from (alignment) (potion)\n");
				break;
			}
			while (perc>=33 && perc<=34) {
				printf("Remove fear (potion)\n");
				break;
			}
			if (perc==35) {
				printf("Sanctuary (potion)\n");
				break;
			}
			while (perc>=36 && perc<=38) {
				printf("Shield of faith +2 (potion)\n");
				break;
			}
			if (perc==39) {
				printf("Shillelagh (oil)\n");
				break;
			}
			while (perc>=40 && perc<=41) {
				printf("Bless weapon (oil)\n");
				break;
			}
			while (perc>=42 && perc<=44) {
				printf("Enlarge person (potion)\n");
				break;
			}
			if (perc==45) {
				printf("Reduce person (potion)\n");
				break;
			}
			while (perc>=46 && perc<=47) {
				printf("Aid (potion)\n");
				break;
			}
			while (perc>=48 && perc<= 50) {
				printf("Barkskin +2 (potion)\n");
				break;
			}
			while (perc>=51 && perc<= 53) {
				printf("Bear's endurance (potion)\n");
				break;
			}
			while (perc>=54 && perc<=56) {
				printf("Blur (potion)\n");
				break;
			}
			while (perc>=57 && perc<= 59) {
				printf("Bull's strength (potion)\n");
				break;
			}
			while (perc>=60 && perc<=62) {
				printf("Cat's grace (potion)\n");
				break;
			}
			while (perc>=63 && perc<=67) {
				printf("Cure moderate wounds (potion)\n");
				break;
			}
			if (perc==68) {
				printf("Darkness (oil)\n");
				break;
			}
			while (perc>=69 && perc<=71) {
				printf("Darkvision (potion)\n");
				break;
			}
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic ring roller */
void mag_ring( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic rod roller */
void mag_rod( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic scroll roller */
void mag_scroll( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic staff roller */
void mag_staff( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Magic wand roller */
void mag_wand( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
		
		case 2:
			dice_roller(1, 100, &perc);
			
		
		case 3:
			dice_roller(1, 100, &perc);
			
	}	
}

/* Wonderous item roller */
void mag_wonder( int x )
{
	int perc;
	
	switch(x) {
		case 1:
			dice_roller(1, 100, &perc);
			
			switch (perc) {
				case 1:
				printf("Quaal's feather token, anchor\n");
				break;
				
				case 2:
				printf("Universal solvent\n");
				break;
				
				case 3:
				printf("Elixir of love\n");
				break;
				
				case 4:
				printf("Unguent of timelessness\n");
				break;
				
				case 5:
				printf("Quaal's feather token, fan\n");
				break;
				
				case 6:
				printf("Dust of tracelessness\n");
				break;
				
				case 7:
				printf("Elixir of hiding\n");
				break;
				
				case 8:
				printf("Elixir of sneaking\n");
				break;
				
				case 9:
				printf("Elixir of swimming\n");
				break;
				
				case 10:
				printf("Elixir of vision\n");
				break;
				
				case 11:
				printf("Silversheen\n");
				break;
				
				case 12:
				printf("Quaal's feather token, bird\n");
				break;
				
				case 13:
				printf("Quaal's feather token, tree\n");
				break;
				
				case 14:
				printf("Quaal's feather token, swan boat\n");
				break;
				
				case 15:
				printf("Elixir of truth\n");
				break;
				
				case 16:
				printf("Quaal's feather token, whip\n");
				break;
				
				case 17:
				printf("Dust of dryness\n");
				break;
				
				case 18:
				printf("Bag of tricks, grey\n");
				break;
				
				case 19:
				printf("Hand of the mage\n");
				break;
				
				case 20:
				printf("Bracers of armor +1\n");
				break;
				
				case 21:
				printf("Cloak of resistance +1\n");
				break;
				
				case 22:
				printf("Pearl of power, 1st-level spell\n");
				break;
				
				case 23:
				printf("Phylactery of faithfulness\n");
				break;
				
				case 24:
				printf("Salve of slipperiness\n");
				break;
				
				case 25:
				printf("Elixir of fire breath\n");
				break;
				
				case 26:
				printf("Pipes of the sewers\n");
				break;
				
				case 27:
				printf("Dust of illusion\n");
				break;
				
				case 28:
				printf("Goggles of minute seeing\n");
				break;
				
				case 29:
				printf("Broach of shielding\n");
				break;
				
				case 30:
				printf("Necklace of fireballs type I\n");
				break;
				
				case 31:
				printf("Dust of appearance\n");
				break;
				
				case 32:
				printf("Hat of disguise\n");
				break;
				
				case 33:
				printf("Pipes of sounding\n");
				break;
				
				case 34:
				printf("Quiver of Ehlonna\n");
				break;
				
				case 35:
				printf("Amulet of natural armor +1\n");
				break;
				
				case 36:
				printf("Heward's handy haversack\n");
				break;
				
				case 37:
				printf("Horn of fog\n");
				break;
				
				case 38:
				printf("Elemental gem\n");
				break;
				
				case 39:
				printf("Robe of bones\n");
				break;
				
				case 40:
				printf("Sovereign glue\n");
				break;
				
				case 41:
				printf("Bag of holding type I\n");
				break;
				
				case 42:
				printf("Boots of elvenkind\n");
				break;
				
				case 43:
				printf("Boots of the winterlands\n");
				break;
				
				case 44:
				printf("Candle of truth\n");
				break;
				
				case 45:
				printf("Cloak of elvenkind\n");
				break;
				
				case 46:
				printf("Eyes of the eagle\n");
				break;
				
				case 47:
				printf("Scarab, golembane\n");
				break;
				
				case 48:
				printf("Necklace of fireballs type II\n");
				break;
				
				case 49:
				printf("Stone of alarm\n");
				break;
				
				case 50:
				printf("Bag of tricks, rust\n");
				break;
				
				case 51:
				printf("Bead of force\n");
				break;
				
				case 52:
				printf("Chime of opening\n");
				break;
				
				case 53:
				printf("Horseshoes of speed\n");
				break;
				
				case 54:
				printf("Rope of climbing\n");
				break;
				
				case 55:
				printf("Dust of disappearance\n");
				break;
				
				case 56:
				printf("Lens of detection\n");
				break;
				
				case 57:
				printf("Vestment, druid's\n");
				break;
				
				case 58:
				printf("Figurine of wondrous power, silver raven\n");
				break;
				
				case 59:
				printf("Amulet of health +2\n");
				break;
				
				case 60:
				printf("Bracers of armor +2\n");
				break;
				
				case 61:
				printf("Cloak of Charisma +2\n");
				break;
				
				case 62:
				printf("Cloak of resistance\n");
				break;
				
				case 63:
				printf("Gauntlets of ogre power\n");
				break;
				
				case 64:
				printf("Gloves of arrow snaring\n");
				break;
				
				case 65:
				printf("Gloves of Dexterity\n");
				break;
				
				case 66:
				printf("Headband of intellect +2\n");
				break;
				
				case 67:
				printf("Ioun stone, clear spindle\n");
				break;
				
				case 68:
				printf("Keoghtom's ointment\n");
				break;
				
				case 69:
				printf("Nolzur's marvelous pigments\n");
				break;
				
				case 70:
				printf("Pearl of power, 2nd-level spell\n");
				break;
				
				case 71:
				printf("Periapt of Wisdom +2\n");
				break;
				
				case 72:
				printf("Stone salve\n");
				break;
				
				case 73:
				printf("Necklace of fireballs type III\n");
				break;
				
				case 74:
				printf("Circlet of persuasion\n");
				break;
				
				case 75:
				printf("Slippers of spider climbing\n");
				break;
				
				case 76:
				printf("Incense of meditation\n");
				break;
				
				case 77:
				printf("Bag of holding type II\n");
				break;
				
				case 78:
				printf("Bracers of archery, lesser\n");
				break;
				
				case 79:
				printf("Ioun stone, dusty rose prism\n");
				break;
				
				case 80:
				printf("Helm of comprehend languages and read magic\n");
				break;
				
				case 81:
				printf("Vest of escape\n");
				break;
				
				case 82:
				printf("Eversmoking bottle\n");
				break;
				
				case 83:
				printf("Murlynd's spoon\n");
				break;
				
				case 84:
				printf("Necklace of fireballs type IV\n");
				break;
				
				case 85:
				printf("Boots of striding and springing\n");
				break;
				
				case 86:
				printf("Wind fan\n");
				break;
				
				case 87:
				printf("Amulet of mighty fists +1\n");
				break;
				
				case 88:
				printf("Horseshoes of a zephyr\n");
				break;
				
				case 89:
				printf("Pipes of haunting\n");
				break;
				
				case 90:
				printf("Necklace of fireballs type V\n");
				break;
				
				case 91:
				printf("Gloves of swimming and climbing\n");
				break;
				
				case 92:
				printf("Bag of tricks, tan\n");
				break;
				
				case 93:
				printf("Circlet of blasting, minor\n");
				break;
				
				case 94:
				printf("Horn of goodness/evil\n");
				break;
				
				case 95:
				printf("Robe of useful items\n");
				break;
				
				case 96:
				printf("Boat, folding\n");
				break;
				
				case 97:
				printf("Cloak of the manta ray\n");
				break;
				
				case 98:
				printf("Bottle of air\n");
				break;
				
				case 99:
				printf("Bag of holding type III\n");
				break;
				
				case 100:
				printf("Periapt of health\n");
				break;
			}
			
		case 2:
			dice_roller(1, 100, &perc);

			switch (perc) {
				case 1:
				printf("Boots of levitation\n");
				break;

				case 2:
				printf("Harp of charming\n");
				break;

				case 3:
				printf("Amulet of natural armor +2\n");
				break;

				case 4:
				printf("Golem manual, flesh\n");
				break;

				case 5:
				printf("Hand of glory\n");
				break;

				case 6:
				printf("Ioun stone, deep red sphere\n");
				break;

				case 7:
				printf("Ioun stone, incandescent blue sphere\n");
				break;

				case 8:
				printf("Ioun stone, pale blue rhomboid\n");
				break;

				case 9:
				printf("Ioun stone, pink and green sphere\n");
				break;

				case 10:
				printf("Ioun stone, pink rhomboid\n");
				break;

				case 11:
				printf("Ioun sphere, scarlet and blue sphere\n");
				break;

				case 12:
				printf("Deck of illusions\n");
				break;

				case 13:
				printf("Necklace of fireballs type VI\n");
				break;

				case 14:
				printf("Candle of invocation\n");
				break;

				case 15:
				printf("Bracers of armor +3\n");
				break;

				case 16:
				printf("Cloak of resistance +3\n");
				break;

				case 17:
				printf("Decanter of endless water\n");
				break;

				case 18:
				printf("Necklace of adaptation\n");
				break;

				case 19:
				printf("Pearl of power, 3rd-level spell\n");
				break;

				case 20:
				printf("Talisman of the sphere\n");
				break;

				case 21:
				printf("Figurine of wondrous power, serpentine owl\n");
				break;

				case 22:
				printf("Necklace of fireballs type VII\n");
				break;

				case 23:
				printf("Strand of prayer beads, lesser\n");
				break;

				case 24:
				printf("Bag of holding type IV\n");
				break;

				case 25:
				printf("Figurine of wondrous power, bronze griffon\n");
				break;

				case 26:
				printf("Figurine of wondrous power, ebony fly\n");
				break;

				case 27:
				printf("Glove of storing\n");
				break;

				case 28:
				printf("Ioun stone, dark blue rhomboid\n");
				break;

				case 29:
				printf("Stone horse, courser\n");
				break;

				case 30:
				printf("Cape of the mountebank\n");
				break;

				case 31:
				printf("Phylactery of undead turning\n");
				break;

				case 32:
				printf("Gauntlet of rust\n");
				break;

				case 33:
				printf("Boots of speed\n");
				break;

				case 34:
				printf("Goggles of night\n");
				break;

				case 35:
				printf("Golem manual, clay\n");
				break;

				case 36:
				printf("Medallion of thoughts\n");
				break;

				case 37:
				printf("Pipes of pain\n");
				break;

				case 38:
				printf("Boccob's blessed book\n");
				break;

				case 39:
				printf("Belt, monk's\n");
				break;

				case 40:
				printf("Gem of brightness\n");
				break;

				case 41:
				printf("Lyre of building\n");
				break;

				case 42:
				printf("Cloak of arachnida\n");
				break;

				case 43:
				printf("Stone horse, destrier\n");
				break;

				case 44:
				printf("Belt of dwarvenkind\n");
				break;

				case 45:
				printf("Periapt of wound closure\n");
				break;

				case 46:
				printf("Horn of the tritons\n");
				break;

				case 47:
				printf("Pearl of the sirens\n");
				break;

				case 48:
				printf("Figurine of wondrous power, onyx dog\n");
				break;

				case 49:
				printf("Amulet of health +4\n");
				break;

				case 50:
				printf("Belt of giant Strength +4\n");
				break;

				case 51:
				printf("Boots, winged\n");
				break;

				case 52:
				printf("Bracers of armor +4\n");
				break;

				case 53:
				printf("Colak of Charisma +4\n");
				break;

				case 54:
				printf("Cloak of resistance +4\n");
				break;

				case 55:
				printf("Gloves of Dexterity +4\n");
				break;

				case 56:
				printf("Headband of intellect +4\n");
				break;

				case 57:
				printf("Pearl of power, 4th-level spell\n");
				break;

				case 58:
				printf("Periapt of Wisdom +4\n");
				break;

				case 59:
				printf("Scabbard of keen edges\n");
				break;

				case 60:
				printf("Figurine of wondrous power, golden lions\n");
				break;

				case 61:
				printf("Chime of interruption\n");
				break;

				case 62:
				printf("Broom of flying\n");
				break;

				case 63:
				printf("Figurine of wondrous power, marble elephant\n");
				break;

				case 64:
				printf("Amulet of natural armor +3\n");
				break;

				case 65:
				printf("Ioun stone, iridescent spindle\n");
				break;

				case 66:
				printf("Bracelet of friends\n");
				break;

				case 67:
				printf("Carpet of flying, 5 ft. by 5 ft.\n");
				break;

				case 68:
				printf("Horn of blasting\n");
				break;

				case 69:
				printf("Ioun stone, pale lavender ellipsoid\n");
				break;

				case 70:
				printf("Ioun stone, pearly white spindle\n");
				break;

				case 71:
				printf("Portable hole\n");
				break;

				case 72:
				printf("Stone of good luck (luckstone)\n");
				break;

				case 73:
				printf("Figurine of wondrous power, ivory goats\n");
				break;

				case 74:
				printf("Rope of entanglement\n");
				break;

				case 75:
				printf("Golem manual, stone\n");
				break;

				case 76:
				printf("Mask of the skull\n");
				break;

				case 77:
				printf("Mattock of the titans\n");
				break;

				case 78:
				printf("Circlet of blasting, major\n");
				break;

				case 79:
				printf("Amulet of mighty fists +2\n");
				break;

				case 80:
				printf("Cloack of displacement, minor\n");
				break;

				case 81:
				printf("Helm of underwater action\n");
				break;

				case 82:
				printf("Bracers of archery, greater\n");
				break;

				case 83:
				printf("Bracers of armor +5\n");
				break;

				case 84:
				printf("Cloack of resistance +5\n");
				break;

				case 85:
				printf("Eyes of doom\n");
				break;

				case 86:
				printf("Pearl of power, 5th-level spell\n");
				break;

				case 87:
				printf("Maul of the titans\n");
				break;

				case 88:
				printf("Strand of prayer beads\n");
				break;

				case 89:
				printf("Cloak of the bat\n");
				break;

				case 90:
				printf("Iron bands of Bilarro\n");
				break;

				case 91:
				printf("Cube of frost resistance\n");
				break;

				case 92:
				printf("Helm of telepathy\n");
				break;

				case 93:
				printf("Periapt of proof against poison\n");
				break;

				case 94:
				printf("Robe of scintillating colors\n");
				break;

				case 95:
				printf("Manual of bodily health +1\n");
				break;

				case 96:
				printf("Manual of gainful exercise +1\n");
				break;

				case 97:
				printf("Manual of quickness in action +1\n");
				break;

				case 98:
				printf("Tome of clear thought +1\n");
				break;

				case 99:
				printf("Tome of leadership and influence +1\n");
				break;

				case 100:
				printf("Tome of understanding +1\n");
				break;
			}
				
		case 3:
			dice_roller(1, 100, &perc);

			switch (perc) {
				case 1:
				printf("Dimensional shackles\n");
				break;

				case 2:
				printf("Figurine of wondrous power, obsidian steed\n");
				break;

				case 3:
				printf("Drums of panic\n");
				break;

				case 4:
				printf("Ioun stone, orange\n");
				break;

				case 5:
				printf("Ioun stone, pale green prism\n");
				break;

				case 6:
				printf("Lantern of revealing\n");
				break;

				case 7:
				printf("Robe of blending\n");
				break;

				case 8:
				printf("Amulet of natural armor +4\n");
				break;

				case 9:
				printf("Amulet of proof against detection and location\n");
				break;

				case 10:
				printf("Carpet of flying, 5ft by 10ft\n");
				break;

				case 11:
				printf("Golem manual, iron\n");
				break;

				case 12:
				printf("Amulet of health +6\n");
				break;

				case 13:
				printf("Belt of giant Strength +6\n");
				break;

				case 14:
				printf("Bracers of armor +6\n");
				break;

				case 15:
				printf("Cloak of Charisma +6\n");
				break;

				case 16:
				printf("Gloves of Dexterity +6\n");
				break;

				case 17:
				printf("Headband of intellect +6\n");
				break;

				case 18:
				printf("Ioun stone, vibrand purple prism\n");
				break;

				case 19:
				printf("Pearl of power, 6th-level spell\n");
				break;

				case 20:
				printf("Periapt of Wisdom +6\n");
				break;

				case 21:
				printf("Scarab of protection\n");
				break;

				case 22:
				printf("Ioun stone, lavender and green ellipsoid\n");
				break;

				case 23:
				printf("Ring gates\n");
				break;

				case 24:
				printf("Crystal ball\n");
				break;

				case 25:
				printf("Golem manual, greater stone\n");
				break;

				case 26:
				printf("Orb of storms\n");
				break;

				case 27:
				printf("Boots of teleportation\n");
				break;

				case 28:
				printf("Bracers of power +7\n");
				break;

				case 29:
				printf("Pearl of power, 7th-level spell\n");
				break;

				case 30:
				printf("Amulet of natural armor +5\n");
				break;

				case 31:
				printf("Cloak of displacement, major\n");
				break;

				case 32:
				printf("Crystal ball with see invisibility\n");
				break;

				case 33:
				printf("Horn of Valhalla\n");
				break;

				case 34:
				printf("Crystal ball with detect thoughts\n");
				break;

				case 35:
				printf("Carpet of flying, 6ft by 9ft\n");
				break;

				case 36:
				printf("Amulet of mighty fists +3\n");
				break;

				case 37:
				printf("Wings of flying\n");
				break;

				case 38:
				printf("Cloak of etherealness\n");
				break;

				case 39:
				printf("Daern's instant fortress\n");
				break;

				case 40:
				printf("Manual of bodily health +2\n");
				break;

				case 41:
				printf("Manual of gainful exercise +2\n");
				break;

				case 42:
				printf("Manual of quickness in action +2\n");
				break;

				case 43:
				printf("Tome of clear thought +2\n");
				break;

				case 44:
				printf("Tome of leadership and influence\n");
				break;

				case 45:
				printf("Tome of understanding +2\n");
				break;

				case 46:
				printf("Eyes of charming\n");
				break;

				case 47:
				printf("Robe of stars\n");
				break;

				case 48:
				printf("Carpet of flying, 10ft by 10ft\n");
				break;

				case 49:
				printf("Darkskull\n");
				break;

				case 50:
				printf("Cube of force\n");
				break;

				case 51:
				printf("Bracers of armor +8\n");
				break;

				case 52:
				printf("Pearl of power, 8th-level spell\n");
				break;

				case 53:
				printf("Crystal ball with telepathy\n");
				break;

				case 54:
				printf("Horn of blasting, greater\n");
				break;

				case 55:
				printf("Pearl of power, two spells\n");
				break;

				case 56:
				printf("Helm of teleportation\n");
				break;

				case 57:
				printf("Gem of seeing\n");
				break;

				case 58:
				printf("Robe of the archmagi\n");
				break;

				case 59:
				printf("Mantle of faith\n");
				break;

				case 60:
				printf("Crystal ball with true seeing\n");
				break;

				case 61:
				printf("Pearl of power, 9th-level spell\n");
				break;

				case 62:
				printf("Well of many worlds\n");
				break;

				case 63:
				printf("Manual of bodily health +3\n");
				break;

				case 64:
				printf("Manual of gainful exercise +3\n");
				break;

				case 65:
				printf("Manual of quickness in action +3\n");
				break;

				case 66:
				printf("Tome of clear thought +3\n");
				break;

				case 67:
				printf("Tome of leadership and influence +3\n");
				break;

				case 68:
				printf("Tome of understanding +3\n");
				break;

				case 69:
				printf("Apparatus of Kwalish\n");
				break;

				case 70:
				printf("Mantle of spell resistance\n");
				break;

				case 71:
				printf("Mirror of opposition\n");
				break;

				case 72:
				printf("Strand of prayer beads, greater\n");
				break;

				case 73:
				printf("Amulet of mighty fists +4\n");
				break;

				case 74:
				printf("Eyes of petrification\n");
				break;

				case 75:
				printf("Bowl of commanding water elementals\n");
				break;

				case 76:
				printf("Brazier of commanding fire elementals\n");
				break;

				case 77:
				printf("Censer of controlling air elementals\n");
				break;

				case 78:
				printf("Stone of controlling earth elementals\n");
				break;

				case 79:
				printf("Manual of bodily health +4\n");
				break;

				case 80:
				printf("Manual of gainful exercise +4\n");
				break;

				case 81:
				printf("Manual of quickness in action +4\n");
				break;

				case 82:
				printf("Tome of clear thought +4\n");
				break;

				case 83:
				printf("Tome of leadership and influence +4\n");
				break;

				case 84:
				printf("Tome of understanding +4\n");
				break;

				case 85:
				printf("Amulet of the planes\n");
				break;

				case 86:
				printf("Robe of eyes\n");
				break;

				case 87:
				printf("Helm of brilliance\n");
				break;

				case 88:
				printf("Manual of bodily health +5\n");
				break;

				case 89:
				printf("Manual of gainful exercise +5\n");
				break;

				case 90:
				printf("Manual of quickness in action +5\n");
				break;

				case 91:
				printf("Tome of clear thought +5\n");
				break;

				case 92:
				printf("Tome of leadership and influence +5\n");
				break;

				case 93:
				printf("Tome of understanding +5\n");
				break;

				case 94:
				printf("Efeeti bottle\n");
				break;

				case 95:
				printf("Amulet of mighty fists +5\n");
				break;

				case 96:
				printf("Chaos diamond\n");
				break;

				case 97:
				printf("Cubic gate\n");
				break;

				case 98:
				printf("Iron flask\n");
				break;

				case 99:
				printf("Mirror of mental prowess\n");
				break;

				case 100:
				printf("Mirror of life trapping\n");
				break;
			}
	}
}
