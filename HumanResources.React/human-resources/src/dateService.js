export function formatDate(date) {
    let jsDate = new Date(Date.parse(date));
    return jsDate.toLocaleDateString();
}