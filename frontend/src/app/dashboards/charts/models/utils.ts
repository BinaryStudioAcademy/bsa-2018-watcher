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

// Now we will define our date comparison functions. These are callbacks
// that we will be providing to the array sort method below.
export function date_sort_asc (date1: Date, date2: Date) {
  // This is a comparison function that will result in dates being sorted in
  // ASCENDING order. As you can see, JavaScript's native comparison operators
  // can be used to compare dates. This was news to me.
  if (date1 > date2) return 1;
  if (date1 < date2) return -1;
  return 0;
}

export function date_sort_desc (date1: Date, date2: Date) {
  // This is a comparison function that will result in dates being sorted in
  // DESCENDING order.
  if (date1 > date2) return -1;
  if (date1 < date2) return 1;
  return 0;
};
