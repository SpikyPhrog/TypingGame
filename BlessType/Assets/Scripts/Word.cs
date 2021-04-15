using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Word
{
   public int id;
   public string word;
   private int charIndex;
   private DisplayWord displayWord;
   
   public Word(string _word, DisplayWord _displayWord, int _id)
   {
      word = _word;
      charIndex = 0;
      displayWord = _displayWord;
      displayWord.SetWord(word);
      id = _id;
   }
   public char GetNextChar()
   {
      return word[charIndex];
   }

   public void InputChar()
   {
      charIndex++;
      displayWord.RemoveChar(charIndex);
   }

   public bool WordTyped()
   {
      bool wordTyped = charIndex >= word.Length;

      if (wordTyped)
      {
         displayWord.RemoveWord();
      }

      return wordTyped;
   }
}
