export function toCapitalizedWords(name: string) {
  if (typeof name !== 'string') {
    return null;
  }
  const words = name.match(/[A-Za-z][a-z]*/g);
  return words.map(capitalize).join(' ');

  function capitalize(word) {
    return word.charAt(0).toUpperCase() + word.substring(1);
  }
}
