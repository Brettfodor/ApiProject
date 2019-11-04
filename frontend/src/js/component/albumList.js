export default function AlbumList(albumList) {
    return `
    <section id='album-list'>
    
    ${AlbumList
        .map(albumList => {
            return `
            <article class="album">
            <li>
                <h3>${albumList.name}</h3>
            </li>
            </article>
   
                `;
        })
        .join("")}
    
   
        
            
           
        </section>  
        
    `

}