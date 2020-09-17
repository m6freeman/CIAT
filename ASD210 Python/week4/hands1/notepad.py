import tkinter as tk
from tkinter import filedialog
from os import getcwd, path

root = tk.Tk()
root.title("NotePyd")
root.geometry("585x400")

def new_document():
    file_name_label["text"] = getcwd()
    main_text.delete("1.0", tk.END)


def save_document():
    fd = tk.filedialog.asksaveasfilename(initialdir=getcwd(), title="Save File",
                            filetypes=(("Text Files", "*.txt"), ("All Files", "*.*")))
    t = main_text.get("1.0", tk.END)
    with open(fd, "w+") as f:
        f.write(t)
    print("Saved")


def open_document():
    fd = tk.filedialog.askopenfilename(initialdir=getcwd(), title="Open File",
                            filetypes=(("Text Files", "*.txt"), ("All Files", "*.*")))
    with open(fd, "r") as f:
        main_text.insert("1.0", f.read())
        file_name_label["text"] = f.name

###     Menu business    ###
menu_bar = tk.Menu(root)

file_menu = tk.Menu(menu_bar, tearoff=0)
file_menu.add_command(label="New", command=new_document)
file_menu.add_command(label="Save", command=save_document)
file_menu.add_command(label="Open", command=open_document)
file_menu.add_separator()
file_menu.add_command(label="Exit", command=root.quit)
menu_bar.add_cascade(label="File", menu=file_menu)

edit_menu = tk.Menu(menu_bar, tearoff=0)
edit_menu.add_command(label="Copy", command=lambda: print("Copied"))
edit_menu.add_command(label="Paste", command=lambda: print("Pasted"))
menu_bar.add_cascade(label="Edit", menu=edit_menu)

root.config(menu=menu_bar)


###     Main Frame   ###
main_frame = tk.Frame(root)
main_scrollbar = tk.Scrollbar(main_frame, orient=tk.VERTICAL)

###     Main text area   ###
main_text = tk.Text(main_frame, yscrollcommand=main_scrollbar.set)
main_text.grid(row=0, column=0)
main_scrollbar.config(command=main_text.yview)
main_scrollbar.grid(row=0, column=1, rowspan=5, sticky=tk.NSEW)
main_frame.pack()

###     Below text area     ###
file_name_label = tk.Label(root, text=getcwd())
file_name_label.pack(side=tk.LEFT)




root.mainloop()

