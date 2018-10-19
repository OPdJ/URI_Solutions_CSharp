FILE = uri_number

all : $(FILE)

$(FILE): compile
	mono $@.exe

compile: $(FILE).cs
	mcs $< -out:$(FILE).exe

hadouken: $(FILE).exe
	mono $(FILE).exe

clean:
	rm $(FILE).exe
